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
                                                            .OrderByDescending(r => r.enter_date)
                                                            .Where(s => s.state == Constants.STATE_OFF)
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
                        end_date = x.end_date
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
                                                            .OrderByDescending(r => r.enter_date)
                                                            .Where(s => s.state == Constants.STATE_ON)
                                                            .ToList();
                    if (staffs.Count == 0) return new List<StaffEntity>();
                    var lastDate = staffs[0].enter_date;
                    var GADb = new GA_UMCEntities();
                    var GAList = GADb.sp_Get_All_Staff(null).ToList();
                    var GALiquite = GADb.PR_ContractLiquite.ToList();
                    foreach (var staff in staffs)
                    {
                        try
                        {
                            var code = int.Parse(staff.staff_code);
                        }
                        catch
                        {
                            continue;
                        }
                        if (GAList.Where(m => int.Parse(m.StaffCode) == int.Parse(staff.staff_code)).FirstOrDefault() == null)
                        {
                            var end_date = GALiquite.Where(m => int.Parse(m.StaffCode) == int.Parse(staff.staff_code)).FirstOrDefault().LiquidationDate;
                            if (end_date > DateTime.Now) continue; 
                            Locker locker;
                            Sho shoes;
                            if (staff.locker_id != null)
                            {
                                locker = db.Lockers.Where(m => m.id == staff.locker_id).FirstOrDefault();
                                locker.state = Constants.STATE_AVAIABLE;
                            }
                            if (staff.shoes_id != null)
                            {
                                shoes = db.Shoes.Where(m => m.id == staff.shoes_id).FirstOrDefault();
                                shoes.state = Constants.STATE_AVAIABLE;
                            }
                            staff.state = Constants.STATE_OFF;
                            staff.end_date = end_date;
                            staff.note = Constants.NOTE_NOT_RETURN_KEY;
                            db.SaveChanges();
                        }
                    }
                    GAList = GAList.Where(m => m.EntryDate >= lastDate).ToList();
                    foreach (var ga in GAList)
                    {
                        if (staffs.Where(m => m.staff_code != Constants.VALUE_DEFAULT && int.Parse(m.staff_code) == int.Parse(ga.StaffCode)) == null)
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
                                state = Constants.STATE_ON
                            };
                            db.Staffs.Add(staff);
                            db.SaveChanges();
                            staffs.Add(staff);
                        }
                    }

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
                        end_date = x.end_date
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
                        ResultInfo lResult = new LockerEntity().DeleteOwned(locker_id1);
                        if (lResult.code != Constants.SUCCESS) return lResult;
                    }
                    if (update.shoes_id is int shoes_id1)
                    {
                        ResultInfo sResult = new ShoesEntity().DeleteOwned(shoes_id1);
                        if (sResult.code != Constants.SUCCESS) return sResult;
                    }
                    update.state = Constants.STATE_OFF;
                    update.end_date = end_date;
                    update.note = note;
                    db.SaveChanges();
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
                        ResultInfo lResult = new LockerEntity().DeleteOwned(locker_id1);
                        if (lResult.code != Constants.SUCCESS) return lResult;
                    }
                    if (update.shoes_id is int shoes_id1)
                    {
                        ResultInfo sResult = new ShoesEntity().DeleteOwned(shoes_id1);
                        if (sResult.code != Constants.SUCCESS) return sResult;
                    }
                    // add new info

                    update.staff_code = staff_code;
                    update.full_name = full_name;
                    update.gender = gender;
                    update.enter_date = enter_date;
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
                            owned = id
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
