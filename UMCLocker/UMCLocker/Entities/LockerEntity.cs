using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMCLocker.Business;

namespace UMCLocker.Entities
{
    public class LockerEntity : Locker
    {
        public LockerEntity()
        {
        }

        public IEnumerable GetAllData()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Locker> lockers = db.Lockers.ToList();
                    return lockers;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Locker> GetEmptyData(int id, string type)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Locker> lockers = db.Lockers
                        .Where(l => l.locker_type == type &&( l.state == Constants.STATE_AVAIABLE || l.owned == id))
                        .ToList();
                    return lockers;
                }
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
                    var delete = db.Lockers.Where(d => d.locker_index == this.locker_index && d.locker_number == locker_number && d.locker_type == locker_type).FirstOrDefault<Locker>();
                    if (delete.owned != null) return new ResultInfo(Constants.ERROR_DELETE_FOREIGN_FIRST, "Locker đã có người sử dụng");
                    db.Lockers.Remove(delete);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, "Xóa thành công");
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public ResultInfo DeleteOwned(int locker_id)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Lockers.Where(l => l.id == locker_id).FirstOrDefault<Locker>();
                    if (update != null)
                    {
                        update.owned = null;
                        update.state = Constants.STATE_AVAIABLE;
                        db.SaveChanges();
                        return new ResultInfo(Constants.SUCCESS, "");
                    }
                    else
                    {
                        return new ResultInfo(Constants.ERROR_COMMON, "");
                    }

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
                    var update = db.Lockers.Where(l => l.locker_index == locker_index && l.locker_number == locker_number && l.locker_type == locker_type).FirstOrDefault<Locker>();
                    if (update != null)
                    {
                        update.locker_index = locker_index;
                        update.locker_number = locker_number;
                        update.locker_type = locker_type;
                        update.state = state;
                        update.owned = owned;
                        db.SaveChanges();
                        return new ResultInfo(Constants.SUCCESS, "Update khóa locker thành công!");
                    }
                    else
                    {
                        return new ResultInfo(Constants.ERROR_COMMON, "Không tồn tại khóa locker này!");

                    }

                }

            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        internal ResultInfo Insert(Locker l)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    Locker locker = db.Lockers.Where(x => x.locker_index == l.locker_index && x.locker_number == l.locker_number && x.locker_type == l.locker_type).FirstOrDefault();
                    if (locker != null) return new ResultInfo(Constants.ERROR_DUPLICATE_DATA, "Đã có tủ locker này rồi");
                    l.state = Constants.STATE_AVAIABLE;
                    db.Lockers.Add(l);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, "");
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public List<Locker> FilterDup(List<Locker> allLocker)
        {
            try
            {

                var emplty = allLocker.Where(l => l.owned != null).ToList();
                return emplty;
            }
            catch
            {
                return null;
            }
        }

        public List<Locker> FilterEmpty(List<Locker> allLocker)
        {
            try
            {
                var emplty = allLocker.Where(l => l.owned == null).ToList();
                return emplty;
            }
            catch
            {
                return null;
            }
        }
        public static List<Locker> FindLocker(int number, int index, List<Locker> allLocker)
        {
            try
            {
                return allLocker.Where(l => l.locker_index == index && l.locker_number == number).ToList();
            }
            catch
            {
                return null;
            }
        }
        public static Dictionary<int, List<int>> AddLockerToDict(List<Locker> lockers)
        {
            if (lockers == null) return null;
            Dictionary<int, List<int>> dictLocker = new Dictionary<int, List<int>>();
            foreach (Locker locker in lockers)
            {
                dictLocker.AddObjectToDict(locker.locker_number, locker.locker_index);
            }
            return dictLocker;
        }

        public ResultInfo IsLockerInUsed()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var locker = db.Lockers.Where(x => x.locker_number == this.locker_number && x.locker_index == this.locker_index && x.locker_type == locker_type).FirstOrDefault();
                    if (locker == null)
                    {
                        return new ResultInfo(Constants.ERROR_KEY_NOT_EXIST, "Chưa có tủ locker này!");
                    }
                    else if (locker.owned != null && locker.owned != owned)
                    {
                        return new ResultInfo(Constants.ERROR_KEY_USED, "Tủ locker đã có người sử dụng");
                    }
                    else
                    {
                        return new ResultInfo(Constants.SUCCESS, locker.id.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new ResultInfo(Constants.ERROR_COMMON, e.Message);
            }
        }
        public bool IsLockerExist()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var locker = db.Lockers.Where(x => x.locker_number == this.locker_number && x.locker_index == this.locker_index && x.locker_type == locker_type).FirstOrDefault();
                    if (locker == null)
                    {
                        return false;
                    }
                    else return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        internal ResultInfo UpdateOwned(Locker locker, int id)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Lockers.Where(l => l.id == locker.id).FirstOrDefault<Locker>();
                    update.owned = id;
                    update.state = Constants.STATE_USED;
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, "");
                }

            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public List<StaffEntity> GetHistory(int locker_id)
        {
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    List<StaffEntity> list = new List<StaffEntity>();
                    var lockerIdParameter = new SqlParameter("@locker_id", locker_id);
                    var result = db.Database
                        .SqlQuery<Staff>("history_locker_key @locker_id", lockerIdParameter)
                        .ToList();
                    list = result.Select((x, i) => new StaffEntity
                    {
                        index = i + 1,
                        id = x.id,
                        staff_code = x.staff_code,
                        full_name = x.full_name,
                        gender = x.gender,
                        enter_date = x.enter_date,
                        locker_id = x.locker_id,
                        shoes_id = x.shoes_id,
                        Locker = db.Lockers.Where(p => p.id == x.locker_id).FirstOrDefault(),
                        department = x.department,
                        position = x.position,
                        Sho = db.Shoes.Where(s => s.id == x.shoes_id).FirstOrDefault(),
                        Dept = db.Depts.Where(d => d.id == x.department).FirstOrDefault(),
                        Pos = db.Pos.Where(p => p.id == x.position).FirstOrDefault(),
                        state = x.state
                    }).OrderBy(r => r.id)
                    .ToList();

                    return list;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }


    }
}

