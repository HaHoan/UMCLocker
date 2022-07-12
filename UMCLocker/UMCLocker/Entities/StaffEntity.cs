using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UMCLocker.Business;
using System.Collections;
using System.ComponentModel;

namespace UMCLocker.Entities
{
    public class StaffEntity : Staff
    {
        public int index { get; set; }

        public string deptName
        {
            get
            {
                if (Dept != null)
                {
                    return Dept.name;

                }
                else
                {
                    return Constants.NO_DATA;
                }
            }


            set { deptName = value; }
        }
        public object clone()
        {
            return this.MemberwiseClone();
        }
        public string posName
        {
            get
            {
                if (Pos != null)
                {
                    return Pos.name;

                }
                else
                {
                    return Constants.NO_DATA;
                }
            }


            set { posName = value; }
        }

        public string genderStr
        {
            get
            {
                if (gender == Constants.MALE)
                {
                    return "Nam";

                }
                else
                {
                    return "Nữ";
                }
            }


            set { genderStr = value; }
        }
        public string locker_number
        {
            get => (Locker == null || Locker.locker_number == 0) ? "" : Locker.locker_number.ToString();
            set { locker_number = value; }
        }
        public string locker_index
        {

            get
            {
                return (Locker == null || Locker.locker_index == 0 ? "" : Locker.locker_index.ToString());
            }
            set { locker_index = value; }
        }
        public string shoes_number
        {
            get => (Sho == null || Sho.shoes_number == 0) ? "" : Sho.shoes_number.ToString();
            set { shoes_number = value; }
        }
        public string shoes_index
        {
            get => (Sho == null || Sho.shoes_index == 0) ? "" : Sho.shoes_index.ToString();
            set { shoes_index = value; }
        }


        public StaffEntity()
        {
            Locker = new Locker();
            Sho = new Sho();
        }
        public StaffEntity(Staff s)
        {
            id = s.id;
            staff_code = s.staff_code;
            full_name = s.full_name;
            gender = s.gender;
            enter_date = s.enter_date;
            department = s.department;
            position = s.position;
            locker_id = s.locker_id;
            shoes_id = s.shoes_id;
            Locker = s.Locker;
            Sho = s.Sho;
            state = s.state;
            end_date = s.end_date;
            note = s.note;
            customer = s.customer;
            if (Locker == null)
            {
                Locker = new Locker();
            }
            if (Sho == null)
            {
                Sho = new Sho();
            }
        }

        public StaffEntity(int id) { }

        public string info
        {
            get
            {
                return string.Format("Mã nhân viên: {0}         Họ tên: {1}          Giới tính:{2}          Ngày vào:{3}            Phòng ban:{4}           Chức vụ:{5}         Số tủ locker:{6}            Số ô locker:{7}         Số tủ giày:{8}          Số ô giày:{9}",
                    staff_code, full_name, genderStr, (enter_date is DateTime date) ? date.ToString("dd/MM/yyyy") : Constants.NO_DATA, deptName, posName, (Locker != null && Locker.locker_number != 0) ? Locker.locker_number.ToString() : Constants.NO_DATA, (Locker != null && Locker.locker_index != 0) ? Locker.locker_index.ToString() : Constants.NO_DATA, (Sho != null && Sho.shoes_number != 0) ? Sho.shoes_number.ToString() : Constants.NO_DATA, (Sho != null && Sho.shoes_index != 0) ? Sho.shoes_index.ToString() : Constants.NO_DATA);
            }
        }

        public static StaffEntity GetStaffById(int id)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var staff = db.Staffs.Where(s => s.id == id).FirstOrDefault<Staff>();
                    if (staff == null) return null;
                    return new StaffEntity(staff);
                }
            }
            catch
            {
                return null;
            }
        }
        public static StaffEntity GetStaffBy(string staff_code, string full_name)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var staff = db.Staffs.Where(s => s.staff_code == staff_code && s.full_name.ToLower().Contains(full_name.ToLower())).FirstOrDefault<Staff>();
                    if (staff == null) return null;
                    return new StaffEntity(staff);
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<Staff> FilterStaffByStaffCode(List<Staff> staffs, string staffCode)
        {
            try
            {
                return staffs.Where(l => l.staff_code == staffCode).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static List<Staff> FilterStaffByName(List<Staff> staffs, string name)
        {
            try
            {
                return staffs.Where(s => s.full_name.ToLower().Contains(name.ToLower())).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static List<Staff> FilterStaffById(List<Staff> staffs, int id)
        {
            try
            {
                return staffs.Where(s => s.id == id).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static List<Staff> FilterStaffByListID(List<Staff> staffs, string ownedStr)
        {
            try
            {
                List<Staff> staffFiler = new List<Staff>();
                string[] idList = ownedStr.Split(Constants.COMMA);
                for (int i = 0; i < idList.Length; i++)
                {
                    List<Staff> staff = staffs.Where(s => s.id.ToString() == idList[i]).ToList();
                    staffFiler.AddRange(staff);
                }
                return staffFiler;
            }
            catch
            {
                return null;
            }
        }
        public ResultInfo Delete()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var delete = db.Staffs.Where(s => s.id == id).FirstOrDefault<Staff>();
                    db.Staffs.Remove(delete);
                    db.SaveChanges();

                    return new ResultInfo(Constants.SUCCESS, delete.id.ToString());
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }
        public List<StaffEntity> GetAllStaffTrash()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Staff> staffs = new List<Staff>();
                    List<StaffEntity> list = new List<StaffEntity>();

                    staffs = db.Staffs.Include(d => d.Dept).Include(p => p.Pos)
                                                            .Include(l => l.Locker)
                                                            .Include(s => s.Sho)
                                                            .OrderBy(r => r.modify_date)
                                                            .Where(s => s.state == Constants.STATE_OFF)
                                                            .ToList();
                    list = staffs.Select((x, i) => new StaffEntity
                    {
                        index = i + 1,
                        id = x.id,
                        staff_code = x.staff_code,
                        full_name = x.full_name,
                        gender = x.gender,
                        customer = x.customer,
                        enter_date = x.enter_date,
                        locker_id = x.locker_id,
                        shoes_id = x.shoes_id,
                        Locker = x.Locker,
                        department = x.department,
                        position = x.position,
                        Sho = x.Sho,
                        Dept = x.Dept,
                        Pos = x.Pos,
                        note = x.note,
                        end_date = x.end_date,
                        take_back_date = x.take_back_date,
                        reason_change_key = x.reason_change_key,
                        ngay_tra_khoa = x.ngay_tra_khoa
                    }).OrderByDescending(m => m.end_date).ToList();

                    return list;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<StaffEntity> GetAllData()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Staff> staffs = new List<Staff>();
                    List<StaffEntity> list = new List<StaffEntity>();

                    staffs = db.Staffs.Include(d => d.Dept).Include(p => p.Pos)
                                                            .Include(l => l.Locker)
                                                            .Include(s => s.Sho)
                                                            .OrderByDescending(r => r.modify_date)
                                                            .Where(s => s.state == Constants.STATE_ON)
                                                            .ToList();

                    list = staffs.Select((x, i) => new StaffEntity
                    {
                        index = i + 1,
                        id = x.id,
                        staff_code = x.staff_code,
                        full_name = x.full_name,
                        gender = x.gender,
                        enter_date = x.enter_date,
                        locker_id = x.locker_id,
                        shoes_id = x.shoes_id,
                        Locker = x.Locker,
                        department = x.department,
                        position = x.position,
                        Sho = x.Sho,
                        Dept = x.Dept,
                        Pos = x.Pos,
                        note = x.note,
                        end_date = x.end_date,
                        customer = x.customer,
                        reason_change_key = x.reason_change_key,
                        date_change_key = x.date_change_key
                    }).ToList();

                    return list;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<StaffEntity> SyncAllData(out string error)
        {
            //try
            //{
            using (var db = new UMCLOCKEREntities())
            {
                List<Staff> staffs = new List<Staff>();
                List<StaffEntity> list = new List<StaffEntity>();

                staffs = db.Staffs.Include(d => d.Dept).Include(p => p.Pos)
                                                        .Include(l => l.Locker)
                                                        .Include(s => s.Sho)
                                                        .OrderByDescending(r => r.enter_date)
                                                        .Where(s => s.state == Constants.STATE_ON)
                                                        .ToList();
                if (staffs.Count == 0)
                {
                    error = "";
                    return new List<StaffEntity>();
                }

                var lastDate = staffs[0].enter_date;
                var GADb = new GA_UMCEntities();
                var GAList = GADb.sp_Get_All_Staff_2().ToList();
                var GALiquite = GADb.PR_ContractLiquite.ToList();
                var GAManageCus = GADb.PR_InputDataToManage.Where(m => m.KindView == 0).ToList();
                foreach (var staff in staffs)
                {
                    var Ga = GAList.Where(m => m.StaffCode == staff.staff_code.ToCompleteString()).FirstOrDefault();
                    if (Ga == null)
                    {
                        var liquite = GALiquite.Where(m => m.StaffCode == staff.staff_code.ToCompleteString()).FirstOrDefault();
                        if (liquite == null) continue;
                        var end_date = liquite.LiquidationDate;

                        if (end_date > DateTime.Now) continue;
                        Locker locker;
                        Sho shoes;
                        if (staff.locker_id != null)
                        {
                            locker = db.Lockers.Where(m => m.id == staff.locker_id).FirstOrDefault();
                            locker.state = Constants.STATE_AVAIABLE;
                            locker.owned = null;
                        }
                        if (staff.shoes_id != null)
                        {
                            shoes = db.Shoes.Where(m => m.id == staff.shoes_id).FirstOrDefault();
                            shoes.state = Constants.STATE_AVAIABLE;
                            shoes.owned = null;
                        }
                        staff.state = Constants.STATE_OFF;
                        staff.end_date = end_date;
                        if (end_date is DateTime endDate)
                        {
                            staff.take_back_date = endDate.AddDays(Constants.MAX_DATE_TAKE_BACK);
                        }
                        staff.note = Constants.NOTE_NOT_RETURN_KEY;
                        var cus = GAManageCus.Where(m => m.Staffcode == staff.staff_code.ToCompleteString()).FirstOrDefault();
                        if (cus != null)
                            staff.customer = cus.Customer;
                        db.SaveChanges();
                    }
                    else
                    {
                        bool isChanged = false;
                        if (staff.full_name.Trim() != Ga.FullName.Trim())
                        {
                            staff.full_name = Ga.FullName;
                            isChanged = true;
                        }
                        if (staff.customer == null || (Ga.Customer != null && staff.customer.Trim() != Ga.Customer.Trim()) || Ga.Customer == null)
                        {
                            staff.customer = Ga.Customer;
                            isChanged = true;
                        }
                        if (staff.enter_date == null || staff.enter_date != Ga.EntryDate)
                        {
                            staff.enter_date = Ga.EntryDate;
                        }
                        if (staff.Dept != null && staff.Dept.name.Trim() != Ga.DeptCode)
                        {
                            var Dept = db.Depts.Where(m => m.name == Ga.DeptCode).FirstOrDefault();
                            if (Dept == null)
                            {
                                Dept dept = new Dept()
                                {
                                    name = Ga.DeptCode
                                };
                                db.Depts.Add(dept);
                                db.SaveChanges();
                                Dept = dept;
                            }
                            staff.department = Dept.id;
                            isChanged = true;
                        }
                        if (staff.Pos != null && staff.Pos.name.Trim() != Ga.DeptCode)
                        {
                            var Pos = db.Pos.Where(m => m.name == Ga.PosName).FirstOrDefault();
                            if (Pos == null)
                            {
                                Pos pos = new Pos()
                                {
                                    name = Ga.PosName
                                };
                                db.Pos.Add(pos);
                                db.SaveChanges();
                                Pos = pos;
                            }
                            staff.position = Pos.id;

                        }


                        if (isChanged)
                            db.SaveChanges();
                    }
                }
                GAList = GAList.Where(m => m.EntryDate >= lastDate).ToList();
                foreach (var ga in GAList)
                {
                    if (staffs.Where(m => m.staff_code != Constants.VALUE_DEFAULT && m.staff_code.ToCompleteString() == ga.StaffCode) == null)
                    {
                        var Dept = db.Depts.Where(m => m.name == ga.DeptCode).FirstOrDefault();
                        if (Dept == null)
                        {
                            Dept dept = new Dept()
                            {
                                name = ga.DeptCode
                            };
                            db.Depts.Add(dept);
                            db.SaveChanges();
                            Dept = dept;
                        }
                        var Pos = db.Pos.Where(m => m.name == ga.PosName).FirstOrDefault();
                        if (Pos == null)
                        {
                            Pos pos = new Pos()
                            {
                                name = ga.PosName
                            };
                            db.Pos.Add(pos);
                            db.SaveChanges();
                            Pos = pos;
                        }
                        Staff staff = new Staff()
                        {
                            staff_code = ga.StaffCode,
                            full_name = ga.FullName,
                            gender = ga.Sex,
                            enter_date = ga.EntryDate,
                            locker_id = null,
                            shoes_id = null,
                            department = Dept.id,
                            position = Pos.id,
                            state = Constants.STATE_ON,
                            customer = ga.Customer
                        };
                        db.Staffs.Add(staff);
                        db.SaveChanges();
                        staffs.Add(staff);
                    }
                }
                staffs = staffs.Where(m => m.state.Trim() == Constants.STATE_ON).ToList();
                list = staffs.Select((x, i) => new StaffEntity
                {
                    index = i + 1,
                    id = x.id,
                    staff_code = x.staff_code,
                    full_name = x.full_name,
                    gender = x.gender,
                    enter_date = x.enter_date,
                    locker_id = x.locker_id,
                    shoes_id = x.shoes_id,
                    Locker = x.Locker,
                    department = x.department,
                    position = x.position,
                    Sho = x.Sho,
                    Dept = x.Dept,
                    Pos = x.Pos,
                    note = x.note,
                    end_date = x.end_date,
                    customer = x.customer
                }).ToList();
                error = "";
                return list;
            }
            //}
            //catch (Exception e)
            //{
            //    error = e.Message.ToString();
            //    return null;
            //}
        }

        public ResultInfo Insert(StaffEntity staff)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    Staff s = new Staff()
                    {
                        staff_code = staff.staff_code,
                        full_name = staff.full_name,
                        gender = staff.gender,
                        enter_date = staff.enter_date,
                        customer = staff.customer,
                        state = Constants.STATE_ON
                    };
                    if (staff.department != null)
                    {
                        s.department = staff.department;
                    }
                    if (staff.position != null)
                    {
                        s.position = staff.position;
                    }
                    if (staff.locker_id != null)
                    {
                        s.locker_id = staff.locker_id;
                    }
                    if (staff.shoes_id != null)
                    {
                        s.shoes_id = staff.shoes_id;
                    }
                    s.modify_date = DateTime.Now;
                    db.Staffs.Add(s);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, s.id.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public ResultInfo MoveToTrash()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Staffs.Where(s => s.id == this.id).FirstOrDefault<Staff>();

                    // delete owned of old key
                    if (update.locker_id is int locker_id1)
                    {
                        ResultInfo lResult = new LockerEntity().DeleteOwned(locker_id1, Constants.STATE_AVAIABLE);
                        if (lResult.code != Constants.SUCCESS) return lResult;
                    }
                    if (update.shoes_id is int shoes_id1)
                    {
                        ResultInfo sResult = new ShoesEntity().DeleteOwned(shoes_id1, Constants.STATE_AVAIABLE);
                        if (sResult.code != Constants.SUCCESS) return sResult;
                    }
                    update.state = Constants.STATE_OFF;
                    update.end_date = end_date;
                    update.take_back_date = take_back_date;
                    update.ngay_tra_khoa = ngay_tra_khoa;
                    update.note = note;
                    update.modify_date = DateTime.Now;
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, update.id.ToString());
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }
        public bool CheckUserExist()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var staff = db.Staffs.Where(m => m.staff_code == this.staff_code).FirstOrDefault();
                    if (staff == null) return false;
                    else return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ResultInfo UpdateKeyInfoWhenNotTakeBackKey()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Staffs.Where(s => s.id == this.id).FirstOrDefault<Staff>();

                    // delete owned of old key
                    if (update.locker_id is int locker_id1)
                    {
                        ResultInfo lResult = new LockerEntity().DeleteOwned(locker_id1, Constants.STATE_RESOLVE);
                        if (lResult.code != Constants.SUCCESS) return lResult;
                    }
                    if (update.shoes_id is int shoes_id1)
                    {
                        ResultInfo sResult = new ShoesEntity().DeleteOwned(shoes_id1, Constants.STATE_RESOLVE);
                        if (sResult.code != Constants.SUCCESS) return sResult;
                    }
                  
                    return new ResultInfo(Constants.SUCCESS, update.id.ToString());
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }
        public ResultInfo Update()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Staffs.Where(s => s.id == this.id).FirstOrDefault<Staff>();

                    // delete owned of old key
                    if (update.locker_id is int locker_id1)
                    {
                        ResultInfo lResult = new LockerEntity().DeleteOwned(locker_id1, Constants.STATE_RESOLVE);
                        if (lResult.code != Constants.SUCCESS) return lResult;
                    }
                    if (update.shoes_id is int shoes_id1)
                    {
                        ResultInfo sResult = new ShoesEntity().DeleteOwned(shoes_id1, Constants.STATE_RESOLVE);
                        if (sResult.code != Constants.SUCCESS) return sResult;
                    }
                    // add new info

                    update.staff_code = staff_code;
                    update.full_name = full_name;
                    update.gender = gender;
                    update.enter_date = enter_date;
                    update.reason_change_key = reason_change_key;
                    update.date_change_key = date_change_key;
                    update.modify_date = DateTime.Now;
                    if (department != null)
                    {
                        update.department = department;
                    }
                    if (position != null)
                    {
                        update.position = position;
                    }
                    if (locker_id != null)
                    {
                        update.locker_id = locker_id;
                    }
                    if (shoes_id != null)
                    {
                        update.shoes_id = shoes_id;
                    }
                    update.state = state;
                    if (end_date is DateTime end_date1)
                    {
                        update.end_date = end_date1;
                    }
                    update.note = note;
                    db.SaveChanges();

                    // update owned for new key
                    if (update.locker_id is int locker_id2)
                    {
                        ResultInfo lResult = new LockerEntity()
                        {
                            id = locker_id2,
                            locker_number = Locker.locker_number,
                            locker_index = Locker.locker_index,
                            locker_type = Locker.locker_type,
                            state = Constants.STATE_USED,
                            owned = id,
                            note = Constants.NOTE_RESOLVE_KEY
                        }.Update();
                        if (lResult.code != Constants.SUCCESS) return lResult;
                    }
                    if (update.shoes_id is int shoes_id2)
                    {
                        ResultInfo sResult = (new ShoesEntity()
                        {
                            id = shoes_id2,
                            shoes_number = Sho.shoes_number,
                            shoes_index = Sho.shoes_index,
                            shoes_type = Sho.shoes_type,
                            state = Constants.STATE_USED,
                            owned = id
                        }.Update());
                        if (sResult.code != Constants.SUCCESS) return sResult;
                    }
                    return new ResultInfo(Constants.SUCCESS, update.id.ToString());
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }


    }
}
