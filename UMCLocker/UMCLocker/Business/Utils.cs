using ExcelDataReader;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMCLocker.Entities;

namespace UMCLocker.Business
{
    public static class Utils
    {
        public static void AddObjectToDict(this Dictionary<int, List<int>> dict, int number, int index)
        {
            List<int> numbers;
            if (dict.ContainsKey(number))
            {
                numbers = dict[number];
                numbers.Add(index);
                dict[number] = numbers;
            }
            else
            {
                numbers = new List<int>();
                numbers.Add(index);
                dict.Add(number, numbers);
            }
        }

        public static void AddObjectToDict(this Dictionary<int, HashSet<int>> dict, int number, int index)
        {
            HashSet<int> numbers;
            if (dict.ContainsKey(number))
            {
                numbers = dict[number];
                numbers.Add(index);
                dict[number] = numbers;
            }
            else
            {
                numbers = new HashSet<int>();
                numbers.Add(index);
                dict.Add(number, numbers);
            }
        }

        public static void RemoveElement(this Dictionary<int, List<int>> dict, int number, int index)
        {
            List<int> indexs = dict[number];
            indexs.Remove(index);
            dict.Remove(number);
            if (indexs.Count > 0)
            {
                dict.Add(number, indexs);
            }
        }

        public static void SetDoubleBuffering(this DataGridView dgv, bool value)
        {
            // Double buffering can make DGV slow in remote desktop
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgv.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                        BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgv, value, null);
            }
        }
        public static ResultInfo AddStaffToDB(string path)
        {
            IExcelDataReader excelReader2007 = null;
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet result = excelReader2007.AsDataSet();
                using (var db = new UMCLOCKEREntities())
                {
                    foreach (System.Data.DataTable table in result.Tables)
                    {
                        for (int i = 3; i < table.Rows.Count; i++)
                        {
                            // reading staff
                            Staff staff = new Staff();
                            string staff_code = table.Rows[i].ItemArray[9].ToString();
                            if (string.IsNullOrEmpty(staff_code))
                            {
                                staff_code = "N/A";
                            }
                            staff.staff_code = staff_code;
                            staff.full_name = table.Rows[i].ItemArray[6].ToString();
                            staff.gender = table.Rows[i].ItemArray[10].ToString();
                            string enterdate = table.Rows[i].ItemArray[4].ToString();

                            if (!string.IsNullOrEmpty(enterdate))
                            {

                                string[] split = { };
                                try
                                {
                                    int indexOfSpace = enterdate.IndexOf(' ');

                                    enterdate = indexOfSpace > 0 ? enterdate.Substring(0, indexOfSpace) : enterdate;

                                    split = enterdate.Split('/');
                                    staff.enter_date = new DateTime(int.Parse(split[2]), int.Parse(split[0]), int.Parse(split[1]));
                                }
                                catch (Exception)
                                {

                                }

                            }
                            string dept = table.Rows[i].ItemArray[2].ToString();
                            if (!string.IsNullOrEmpty(dept))
                            {
                                staff.Dept = db.Depts.Where(x => x.name == dept).FirstOrDefault();
                                if (staff.Dept != null)
                                    staff.department = staff.Dept.id;
                            }
                            string pos = table.Rows[i].ItemArray[5].ToString();
                            if (!string.IsNullOrEmpty(pos))
                            {
                                staff.Pos = db.Pos.Where(x => x.name == pos).FirstOrDefault();
                                if (staff.Pos != null)
                                    staff.position = staff.Pos.id;
                            }
                            staff.state = Constants.STATE_ON;
                            var check = db.Staffs.Where(m => m.staff_code == staff.staff_code).FirstOrDefault();
                            if (check == null)
                            {
                                db.Staffs.Add(staff);
                                db.SaveChanges();
                            }

                        }
                    }


                }
                excelReader2007.Close();
                Console.Read();
                return new ResultInfo(Constants.SUCCESS, "Import success!");
            }
            catch (Exception e)
            {
                if (excelReader2007 != null)
                    excelReader2007.Close();
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }
        public static ResultInfo ImportKeyFromExcelToDb(string path)
        {
            IExcelDataReader excelReader2007 = null;
            string locker_nu = "Locker nữ";
            string locker_nam = "Locker nam";
            string giay_nu = "giày nữ";
            string giay_nam = "giày nam";
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet result = excelReader2007.AsDataSet();
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {

                    foreach (DataTable table in result.Tables)
                    {
                        for (int i = 1; i < table.Rows.Count; i++)
                        {
                            int from_index = int.Parse(table.Rows[i].ItemArray[0].ToString());
                            int to_index = int.Parse(table.Rows[i].ItemArray[1].ToString());
                            int soo_index = int.Parse(table.Rows[i].ItemArray[2].ToString());
                            string loaitu = table.Rows[i].ItemArray[3].ToString();
                            string loaikey = "";
                            if (loaitu == locker_nu)
                            {
                                loaitu = "F";
                                loaikey = "locker";
                            }
                            else if (loaitu == locker_nam)
                            {
                                loaitu = "M";
                                loaikey = "locker";
                            }
                            else if (loaitu == giay_nu)
                            {
                                loaitu = "F";
                                loaikey = "shoes";
                            }
                            else if (loaitu == giay_nam)
                            {
                                loaitu = "M";
                                loaikey = "shoes";
                            }

                            var from = new SqlParameter("@from", from_index);
                            var to = new SqlParameter("@to", to_index);
                            var soo1tu = new SqlParameter("@soo1tu", soo_index);
                            var loaitu1 = new SqlParameter("@loaitu", loaitu);
                            if (loaikey == "locker")
                            {
                                db.Database.ExecuteSqlCommand("enter_locker @from, @to,@soo1tu, @loaitu",
                               parameters: new[] { from, to, soo1tu, loaitu1 });
                            }
                            else
                            {
                                db.Database.ExecuteSqlCommand("enter_shoes @from, @to,@soo1tu, @loaitu",
                                parameters: new[] { from, to, soo1tu, loaitu1 });
                            }

                        }
                    }


                }
                excelReader2007.Close();
                Console.Read();
                return new ResultInfo(Constants.SUCCESS, "Import success!");
            }
            catch (Exception e)
            {
                if (excelReader2007 != null)
                    excelReader2007.Close();
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }

        }
        public static ResultInfo ImportAllStaffToDB(string path)
        {
            IExcelDataReader excelReader2007 = null;

            //try
            //{
            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];
            Worksheet sheet1 = workbook.Worksheets[1];
            Worksheet sheet2 = workbook.Worksheets[2];
            sheet.Name = "Danh sách nhân viên bị trùng khóa";
            sheet1.Name = "Danh sách nhân viên bị trùng Code";
            sheet2.Name = "Danh sách nhân viên nhập sai định dạng ngày vào";
            int row = 1;
            int row1 = 1;
            int row2 = 1;
            sheet1.Range[string.Format("A{0}", row)].Text = "Mã nhân viên";
            sheet1.Range[string.Format("B{0}", row)].Text = "Họ và tên";
            row1++;
            sheet2.Range[string.Format("A{0}", row)].Text = "Mã nhân viên";
            sheet2.Range[string.Format("B{0}", row)].Text = "Họ và tên";
            row2++;
            sheet.Range[string.Format("A{0}", row)].Text = "Mã nhân viên";
            sheet.Range[string.Format("B{0}", row)].Text = "Họ và tên";
            sheet.Range[string.Format("C{0}", row)].Text = "Giới tính";
            sheet.Range[string.Format("D{0}", row)].Text = "Số tủ locker";
            sheet.Range[string.Format("E{0}", row)].Text = "Số ô locker";
            sheet.Range[string.Format("F{0}", row)].Text = "Trạng thái";
            sheet.Range[string.Format("G{0}", row)].Text = "Số tủ giày";
            sheet.Range[string.Format("H{0}", row)].Text = "Số ô giày";
            sheet.Range[string.Format("I{0}", row)].Text = "Trạng thái";
            row++;
            FileStream stream = new FileStream(path, FileMode.Open);
            excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet result = excelReader2007.AsDataSet();
            DataTable table = result.Tables[0];
            HashSet<string> hsDept = new HashSet<string>();
            HashSet<string> hsPos = new HashSet<string>();
            Dictionary<int, HashSet<int>> dictLocker = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> dictShoes = new Dictionary<int, HashSet<int>>();
            int rowTemp = row;
            using (var db = new UMCLOCKEREntities())
            {
                {
                    for (int i = 3; i < table.Rows.Count; i++)
                    {
                        string deptStr = table.Rows[i].ItemArray[5].ToString();
                        string posStr = table.Rows[i].ItemArray[7].ToString();
                        if (string.IsNullOrEmpty(deptStr))
                        {
                            deptStr = "N/A";
                        }
                        if (string.IsNullOrEmpty(posStr))
                        {
                            posStr = "N/A";
                        }
                        hsDept.Add(deptStr);
                        hsPos.Add(posStr);
                    }
                }
                foreach (string name in hsDept)
                {
                    Dept dept = new Dept();
                    dept.name = name;
                    db.Depts.Add(dept);
                    db.SaveChanges();
                }
                foreach (string name in hsPos)
                {
                    Pos pos = new Pos();
                    pos.name = name;
                    db.Pos.Add(pos);
                    db.SaveChanges();
                }
                for (int i = 3; i < table.Rows.Count; i++)
                {
                    // reading staff
                    Staff staff = new Staff();
                    string staff_code = table.Rows[i].ItemArray[1].ToString();
                    if (string.IsNullOrEmpty(staff_code))
                    {
                        staff_code = "N/A";
                    }
                    staff.staff_code = staff_code;
                    staff.full_name = table.Rows[i].ItemArray[2].ToString();
                    staff.gender = table.Rows[i].ItemArray[3].ToString();
                    string enterdate = table.Rows[i].ItemArray[4].ToString();

                    if (!string.IsNullOrEmpty(enterdate))
                    {

                        string[] split = { };
                        try
                        {
                            int indexOfSpace = enterdate.IndexOf(' ');

                            enterdate = indexOfSpace > 0 ? enterdate.Substring(0, indexOfSpace) : enterdate;

                            split = enterdate.Split('/');
                            staff.enter_date = new DateTime(int.Parse(split[2]), int.Parse(split[0]), int.Parse(split[1]));
                        }
                        catch (Exception)
                        {
                            sheet2.Range[string.Format("A{0}", row2)].Text = staff.staff_code;
                            sheet2.Range[string.Format("B{0}", row2)].Text = staff.full_name;
                            row2++;
                        }

                    }
                    string dept = table.Rows[i].ItemArray[5].ToString();
                    if (!string.IsNullOrEmpty(dept))
                    {
                        staff.Dept = db.Depts.Where(x => x.name == dept).FirstOrDefault();
                        if (staff.Dept != null)
                            staff.department = staff.Dept.id;
                    }
                    string cus = table.Rows[i].ItemArray[6].ToString();
                    string pos = table.Rows[i].ItemArray[7].ToString();
                    if (!string.IsNullOrEmpty(pos))
                    {
                        staff.Pos = db.Pos.Where(x => x.name == pos).FirstOrDefault();
                        if (staff.Pos != null)
                            staff.position = staff.Pos.id;
                    }
                    // locker
                    string lockerNumberStr = table.Rows[i].ItemArray[8].ToString();
                    string lockerIndexStr = table.Rows[i].ItemArray[9].ToString();
                    string shoesNumberStr = table.Rows[i].ItemArray[10].ToString();
                    string shoesIndexStr = table.Rows[i].ItemArray[11].ToString();
                    ResultInfo rsLocker = new ResultInfo();
                    ResultInfo rsShoes = new ResultInfo();

                    if (!string.IsNullOrWhiteSpace(lockerNumberStr) &&
                        !string.IsNullOrWhiteSpace(lockerIndexStr))
                    {
                        try
                        {
                            rsLocker = new LockerEntity()
                            {

                                locker_number = int.Parse(lockerNumberStr),
                                locker_index = int.Parse(lockerIndexStr),
                                locker_type = staff.gender
                            }.IsLockerInUsed();
                            if (rsLocker.code == Constants.SUCCESS)
                            {
                                staff.locker_id = int.Parse(rsLocker.message);
                            }
                        }
                        catch (Exception e)
                        {

                            Console.Write(e);
                        }

                    }
                    else
                    {
                        rsLocker.code = Constants.ERROR_LACK_KEY;
                        rsLocker.message = "Thiếu key";
                    }

                    if (!string.IsNullOrWhiteSpace(shoesNumberStr) &&
                        !string.IsNullOrWhiteSpace(shoesIndexStr))
                    {
                        try
                        {
                            rsShoes = new ShoesEntity()
                            {
                                shoes_number = int.Parse(shoesNumberStr),
                                shoes_index = int.Parse(shoesIndexStr),
                                shoes_type = staff.gender
                            }.IsShoesInUsed();
                            if (rsShoes.code == Constants.SUCCESS)
                            {
                                staff.shoes_id = int.Parse(rsShoes.message);
                            }

                        }
                        catch (Exception e)
                        {
                            Console.Write(e);
                        }

                    }
                    else
                    {
                        rsShoes.code = Constants.ERROR_LACK_KEY;
                        rsShoes.message = "Thiếu key";
                    }
                    if (rsLocker.code != Constants.SUCCESS || rsShoes.code != Constants.SUCCESS)
                    {
                        sheet.Range[string.Format("A{0}", row)].Text = staff.staff_code;
                        sheet.Range[string.Format("B{0}", row)].Text = staff.full_name;
                        sheet.Range[string.Format("C{0}", row)].Text = staff.gender;
                        sheet.Range[string.Format("D{0}", row)].Text = lockerNumberStr;
                        sheet.Range[string.Format("E{0}", row)].Text = lockerIndexStr;
                        sheet.Range[string.Format("F{0}", row)].Text = rsLocker.code == Constants.SUCCESS ? "OK" : rsLocker.message;
                        sheet.Range[string.Format("G{0}", row)].Text = shoesNumberStr;
                        sheet.Range[string.Format("H{0}", row)].Text = shoesIndexStr;
                        sheet.Range[string.Format("I{0}", row)].Text = rsShoes.code == Constants.SUCCESS ? "OK" : rsShoes.message;
                        row++;
                    }

                    staff.state = Constants.STATE_ON;

                    var check = db.Staffs.Where(m => m.staff_code != Constants.VALUE_DEFAULT && m.staff_code == staff_code).FirstOrDefault();
                    if (check == null)
                    {
                        db.Staffs.Add(staff);
                        db.SaveChanges();
                    }
                    else
                    {
                        sheet1.Range[string.Format("A{0}", row1)].Text = staff.staff_code;
                        sheet1.Range[string.Format("B{0}", row1)].Text = staff.full_name;
                        row1++;
                    }


                }
            }
            workbook.SaveToFile(@"c:\UMCLocker\duplicate_key.xlsx", ExcelVersion.Version2013);
            excelReader2007.Close();
            Console.Read();
            return new ResultInfo(Constants.SUCCESS, "Import success!");
            //}
            //catch (Exception e)
            //{
            //    if (excelReader2007 != null)
            //        excelReader2007.Close();
            //    return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            //}

        }

        public static void UpdateKey()
        {
            //  List<StaffEntity> staffs = (new StaffEntity()).GetAllData(0);
            //foreach(Staff staff in staffs)
            //{
            //    if (staff.locker_number > 0 && staff.locker_index > 0)
            //    {
            //        LockerEntity locker = new LockerEntity(staff.locker_index, staff.locker_number, staff.id);
            //        locker.Update();
            //    }

            //    if (staff.shoes_index > 0 && staff.shoes_number > 0)
            //    {
            //        ShoesEntity shoes = new ShoesEntity(staff.shoes_index, staff.shoes_number, staff.id);
            //        shoes.Update();
            //    }
            //}
        }
        public static ResultInfo ImportQuitWork(string path)
        {
            IExcelDataReader excelReader2007 = null;
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                try
                {
                    excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                if (excelReader2007 == null)
                {
                    try
                    {
                        excelReader2007 = ExcelReaderFactory.CreateReader(stream);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                DataSet result = excelReader2007.AsDataSet();
                using (var db = new UMCLOCKEREntities())
                {
                    foreach (System.Data.DataTable table in result.Tables)
                    {
                        for (int i = 6; i < table.Rows.Count; i++)
                        {
                            // reading staff
                            string staff_code = table.Rows[i].ItemArray[1].ToString();
                            if (string.IsNullOrEmpty(staff_code))
                            {
                                continue;
                            }
                            string full_name = table.Rows[i].ItemArray[2].ToString();
                            if (string.IsNullOrEmpty(full_name))
                            {
                                continue;
                            }

                            StaffEntity staff = StaffEntity.GetStaffBy(staff_code, full_name);
                            if (staff == null)
                            {
                                continue;
                            }
                            string end_date = table.Rows[i].ItemArray[8].ToString();
                            if (!string.IsNullOrEmpty(end_date))
                            {

                                if (!string.IsNullOrEmpty(end_date))
                                {
                                    try
                                    {
                                        staff.end_date = DateTime.Parse(end_date);
                                    }
                                    catch
                                    {

                                    }
                                    if (staff.end_date == null)
                                    {
                                        try
                                        {
                                            staff.end_date = DateTime.ParseExact(end_date, "dd/MM/yyyy", null);

                                        }
                                        catch
                                        {

                                        }
                                    }
                                    if (staff.end_date == null)
                                    {
                                        try
                                        {
                                            staff.end_date = DateTime.ParseExact(end_date.Substring(0, 10), "MM/dd/yyyy", null);

                                        }
                                        catch
                                        {

                                        }
                                    }
                                    if (staff.end_date == null)
                                    {
                                        try
                                        {
                                            staff.end_date = DateTime.ParseExact(end_date, "d/M/yyyy", null);
                                        }
                                        catch
                                        {

                                        }
                                    }


                                }
                            }
                            if (staff.state.TrimEnd() == Constants.STATE_ON)
                            {
                                staff.note = Constants.NOTE_NOT_RETURN_KEY;
                                staff.MoveToTrash();
                            }
                        }
                    }


                }
                excelReader2007.Close();
                Console.Read();
                return new ResultInfo(Constants.SUCCESS, "Import success!");
            }
            catch (Exception e)
            {
                if (excelReader2007 != null)
                    excelReader2007.Close();
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public static ResultInfo duplicate(string path)
        {
            IExcelDataReader excelReader2007 = null;
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet result = excelReader2007.AsDataSet();
                using (var db = new UMCLOCKEREntities())
                {

                    var table = result.Tables[0];
                    for (int i = 3; i < table.Rows.Count; i++)
                    {
                        // reading staff
                        Staff staff = new Staff();
                        try
                        {
                            string Code = table.Rows[i].ItemArray[1].ToString();
                            string Sex = table.Rows[i].ItemArray[3].ToString();
                            string so_tu_locker = table.Rows[i].ItemArray[8].ToString();
                            string so_o_locker = table.Rows[i].ItemArray[9].ToString();
                            string so_tu_shoes = table.Rows[i].ItemArray[10].ToString();
                            string so_o_shoes = table.Rows[i].ItemArray[11].ToString();
                            var temp = new TEMP()
                            {
                                Code = Code,
                                locker_number = so_tu_locker,
                                locker_index = so_o_locker,
                                shoes_number = so_tu_shoes,
                                shoes_index = so_o_shoes,
                                Sex = Sex

                            };
                            db.TEMPs.Add(temp);
                            db.SaveChanges();
                        }
                        catch
                        {

                        }


                    }

                }

                excelReader2007.Close();
                Console.Read();
                return new ResultInfo(Constants.SUCCESS, "Import success!");
            }
            catch (Exception e)
            {
                if (excelReader2007 != null)
                    excelReader2007.Close();
                return new ResultInfo(Constants.ERROR_COMMON, e.ToString());
            }
        }
    }

    public static class ExportUtils
    {
        public static string GetFileName(FolderBrowserDialog choofdlog, string fileNameExcel)
        {
            string folderName = choofdlog.SelectedPath;
            string[] fileEntries = Directory.GetFiles(folderName);
            string fileName = "";
            int i = -1;
            foreach (var file in fileEntries)
            {
                if (file.Contains(fileNameExcel))
                {
                    int start = file.IndexOf('(');
                    int end = file.IndexOf(')');
                    if (start > 0 && end > 0)
                    {
                        string index = file.Substring(start + 1, end - start - 1);
                        if (int.Parse(index) > i)
                        {
                            i = int.Parse(index);
                        }
                    }
                    else
                    {
                        if (i < 0)
                            i = 0;
                    }

                }
            }
            if (i < 0)
            {
                fileName = folderName + "\\" + fileNameExcel + ".xlsx";
            }
            else
            {
                fileName = folderName + "\\" + fileNameExcel + "(" + (i + 1).ToString() + ")" + ".xlsx";
            }
            return fileName;
        }
        public static ResultInfo ExportStaff(List<StaffEntity> staffs, string path)
        {
            try
            {
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];

                int row = 1;
                sheet.Range[string.Format("A{0}", row)].Text = "STT";
                sheet.Range[string.Format("B{0}", row)].Text = "Mã nhân viên";
                sheet.Range[string.Format("C{0}", row)].Text = "Họ và tên";
                sheet.Range[string.Format("D{0}", row)].Text = "Giới tính";
                sheet.Range[string.Format("E{0}", row)].Text = "Ngày vào";
                sheet.Range[string.Format("F{0}", row)].Text = "Khách hàng";
                sheet.Range[string.Format("G{0}", row)].Text = "Phòng ban";
                sheet.Range[string.Format("H{0}", row)].Text = "Vị trí";
                sheet.Range[string.Format("I{0}", row)].Text = "Locker";
                sheet.Range["I1:J1"].Merge();
                sheet.Range[string.Format("K{0}", row)].Text = "Shoes";
                sheet.Range["K1:L1"].Merge();
                sheet.Range[string.Format("M{0}", row)].Text = "Ngày đổi khóa cuối cùng";
                sheet.Range[string.Format("N{0}", row)].Text = "Lý do đổi khóa";
                row++;
                sheet.Range[string.Format("H{0}", row)].Text = "Số tủ";
                sheet.Range[string.Format("I{0}", row)].Text = "Số ô";
                sheet.Range[string.Format("J{0}", row)].Text = "Số tủ";
                sheet.Range[string.Format("K{0}", row)].Text = "Số ô";

                row++;
                foreach (var staff in staffs)
                {
                    sheet.Range[string.Format("A{0}", row)].Text = staff.index.ToString();
                    sheet.Range[string.Format("A{0}", row)].NumberFormat = "0";
                    sheet.Range[string.Format("A{0}", row)].NumberValue = staff.index;
                    string staff_code = "N/A";
                    try
                    {
                        staff_code = string.Format("{0:00000}", int.Parse(staff.staff_code));
                        sheet.Range[string.Format("B{0}", row)].Text = staff_code;
                    }
                    catch (Exception)
                    {
                        sheet.Range[string.Format("B{0}", row)].Text = "N/A";
                    }

                    sheet.Range[string.Format("C{0}", row)].Text = staff.full_name;
                    sheet.Range[string.Format("D{0}", row)].Text = staff.genderStr;
                    if (staff.enter_date is DateTime enterDate)
                    {
                        sheet.Range[string.Format("E{0}", row)].Text = enterDate.ToShortDateString();
                    }

                    sheet.Range[string.Format("F{0}", row)].Text = staff.customer != null ? staff.customer : "";
                    sheet.Range[string.Format("G{0}", row)].Text = staff.deptName;
                    sheet.Range[string.Format("H{0}", row)].Text = staff.posName;
                    if (staff.Locker == null)
                    {
                        sheet.Range[string.Format("I{0}", row)].Text = "";
                        sheet.Range[string.Format("J{0}", row)].Text = "";
                    }
                    else
                    {
                        sheet.Range[string.Format("I{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("I{0}", row)].NumberValue = staff.Locker.locker_number;
                        sheet.Range[string.Format("J{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("J{0}", row)].NumberValue = staff.Locker.locker_index;
                    }
                    if (staff.Sho == null)
                    {
                        sheet.Range[string.Format("K{0}", row)].Text = "";
                        sheet.Range[string.Format("L{0}", row)].Text = "";
                    }
                    else
                    {
                        sheet.Range[string.Format("K{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("K{0}", row)].NumberValue = staff.Sho.shoes_number;
                        sheet.Range[string.Format("L{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("L{0}", row)].NumberValue = staff.Sho.shoes_index;
                    }
                    if (staff.date_change_key is DateTime date_change_key)
                    {
                        sheet.Range[string.Format("M{0}", row)].Text = date_change_key.ToShortDateString();
                    }

                    sheet.Range[string.Format("N{0}", row)].Text = staff.reason_change_key == null ? "" : staff.reason_change_key;
                    row++;
                }
                workbook.SaveToFile(path, ExcelVersion.Version2013);
                return new ResultInfo()
                {
                    code = Constants.SUCCESS,
                    message = "Export successfully"
                };
            }
            catch (Exception e)
            {
                return new ResultInfo()
                {
                    code = Constants.ERROR_COMMON,
                    message = e.Message.ToString()
                };
            }
        }
        public static ResultInfo ExportStaffTrash(List<StaffEntity> staffs, string path)
        {
            try
            {
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];

                int row = 1;
                sheet.Range[string.Format("A{0}", row)].Text = "STT";
                sheet.Range[string.Format("B{0}", row)].Text = "Mã nhân viên";
                sheet.Range[string.Format("C{0}", row)].Text = "Họ và tên";
                sheet.Range[string.Format("D{0}", row)].Text = "Giới tính";
                sheet.Range[string.Format("E{0}", row)].Text = "Ngày vào";
                sheet.Range[string.Format("F{0}", row)].Text = "Khách hàng";
                sheet.Range[string.Format("G{0}", row)].Text = "Phòng ban";
                sheet.Range[string.Format("H{0}", row)].Text = "Vị trí";
                sheet.Range[string.Format("I{0}", row)].Text = "Locker";
                sheet.Range["I1:J1"].Merge();
                sheet.Range[string.Format("K{0}", row)].Text = "Shoes";
                sheet.Range["K1:L1"].Merge();
                sheet.Range[string.Format("M{0}", row)].Text = "Ngày kết thúc";
                sheet.Range[string.Format("N{0}", row)].Text = "Ghi chú";

                row++;
                sheet.Range[string.Format("H{0}", row)].Text = "Số tủ";
                sheet.Range[string.Format("I{0}", row)].Text = "Số ô";
                sheet.Range[string.Format("J{0}", row)].Text = "Số tủ";
                sheet.Range[string.Format("K{0}", row)].Text = "Số ô";

                row++;
                foreach (var staff in staffs)
                {
                    sheet.Range[string.Format("A{0}", row)].Text = staff.index.ToString();
                    sheet.Range[string.Format("A{0}", row)].NumberFormat = "0";
                    sheet.Range[string.Format("A{0}", row)].NumberValue = staff.index;
                    string staff_code = "N/A";
                    try
                    {
                        staff_code = string.Format("{0:00000}", int.Parse(staff.staff_code));
                        sheet.Range[string.Format("B{0}", row)].Text = staff_code;
                    }
                    catch (Exception)
                    {
                        sheet.Range[string.Format("B{0}", row)].Text = "N/A";
                    }

                    sheet.Range[string.Format("C{0}", row)].Text = staff.full_name;
                    sheet.Range[string.Format("D{0}", row)].Text = staff.genderStr;
                    if (staff.enter_date is DateTime enterDate)
                    {
                        sheet.Range[string.Format("E{0}", row)].Text = enterDate.ToShortDateString();
                    }

                    sheet.Range[string.Format("F{0}", row)].Text = staff.customer != null ? staff.customer : "";
                    sheet.Range[string.Format("G{0}", row)].Text = staff.deptName;
                    sheet.Range[string.Format("H{0}", row)].Text = staff.posName;
                    if (staff.Locker == null)
                    {
                        sheet.Range[string.Format("I{0}", row)].Text = "";
                        sheet.Range[string.Format("J{0}", row)].Text = "";
                    }
                    else
                    {
                        sheet.Range[string.Format("I{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("I{0}", row)].NumberValue = staff.Locker.locker_number;
                        sheet.Range[string.Format("J{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("J{0}", row)].NumberValue = staff.Locker.locker_index;
                    }
                    if (staff.Sho == null)
                    {
                        sheet.Range[string.Format("K{0}", row)].Text = "";
                        sheet.Range[string.Format("L{0}", row)].Text = "";
                    }
                    else
                    {
                        sheet.Range[string.Format("K{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("K{0}", row)].NumberValue = staff.Sho.shoes_number;
                        sheet.Range[string.Format("L{0}", row)].NumberFormat = "0";
                        sheet.Range[string.Format("L{0}", row)].NumberValue = staff.Sho.shoes_index;
                    }
                    if (staff.end_date is DateTime endDate)
                    {
                        sheet.Range[string.Format("M{0}", row)].Text = endDate.ToShortDateString();
                    }
                    sheet.Range[string.Format("N{0}", row)].Text = staff.note;
                    row++;
                }
                workbook.SaveToFile(path, ExcelVersion.Version2013);
                return new ResultInfo()
                {
                    code = Constants.SUCCESS,
                    message = "Export successfully"
                };
            }
            catch (Exception e)
            {
                return new ResultInfo()
                {
                    code = Constants.ERROR_COMMON,
                    message = e.Message.ToString()
                };
            }

        }
    }
}
