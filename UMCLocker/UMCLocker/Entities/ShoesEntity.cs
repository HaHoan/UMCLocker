using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMCLocker.Business;

namespace UMCLocker.Entities
{
    public class ShoesEntity : Sho
    {
        public ShoesEntity() { }
        public ShoesEntity(int? index, int? number)
        {
            if (index is int i)
            {
                shoes_index = i;
            }
            if (number is int n)
            {
                shoes_number = n;
            }
        }

        public ShoesEntity(int? index, int? number, int owned)
        {
            if (index is int i)
            {
                shoes_index = i;
            }
            if (number is int n)
            {
                shoes_number = n;
            }
            this.owned = owned;
        }
        public IEnumerable GetAllData()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Sho> shoes = db.Shoes.ToList();
                    return shoes;
                }
            }
            catch
            {
                return null;
            }
        }

        public List<Sho> GetEmptyData(int id, string type)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Sho> shoes = db.Shoes
                        .Where(s => s.shoes_type == type &&( s.state == Constants.STATE_AVAIABLE || s.owned == id))
                        .ToList();
                    return shoes;
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
                    var delete = db.Shoes.Where(d => d.shoes_index == shoes_index && d.shoes_number == shoes_number && d.shoes_type == shoes_type).FirstOrDefault<Sho>();
                    db.Shoes.Remove(delete);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, "Xóa thành công");
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
                    var update = db.Shoes.Where(s => s.shoes_index == shoes_index && s.shoes_number == shoes_number && s.shoes_type == shoes_type).FirstOrDefault<Sho>();
                    if (update != null)
                    {
                        update.shoes_index = shoes_index;
                        update.shoes_number = shoes_number;
                        update.shoes_type = shoes_type;
                        update.state = state;
                        update.owned = owned;
                        db.SaveChanges();
                        return new ResultInfo(Constants.SUCCESS, "Update khóa giày thành công!");
                    }
                    else return new ResultInfo(Constants.ERROR_COMMON, "Không tồn tại khóa giày này");
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public ResultInfo DeleteOwned(int shoes_id)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Shoes.Where(s => s.id == shoes_id).FirstOrDefault<Sho>();
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

        public List<Sho> FilterEmpty(List<Sho> allShoes)
        {
            try
            {
                var emplty = allShoes.Where(l => l.owned == null).ToList();
                return emplty;
            }
            catch
            {
                return null;
            }
        }

        public List<Sho> FilterDup(List<Sho> allShoes)
        {
            try
            {
                var emplty = allShoes.Where(l => l.owned != null).ToList();
                return emplty;
            }
            catch
            {
                return null;
            }
        }

        public static Dictionary<int, List<int>> AddShoesToDict(List<Sho> shoes)
        {
            if (shoes == null) return null ;
            Dictionary<int, List<int>> dictShoes = new Dictionary<int, List<int>>();
            foreach (Sho s in shoes)
            {
                List<int> shoesInNumber;
                if (dictShoes.ContainsKey(s.shoes_number))
                {
                    shoesInNumber = dictShoes[s.shoes_number];
                    shoesInNumber.Add(s.shoes_index);
                    dictShoes[s.shoes_number] = shoesInNumber;
                }
                else
                {
                    shoesInNumber = new List<int>();
                    shoesInNumber.Add(s.shoes_index);
                    dictShoes.Add(s.shoes_number, shoesInNumber);
                }
            }
            return dictShoes;
        }

        public static List<Sho> FindShoes(int number, int index, List<Sho> allLocker)
        {
            try
            {
                return allLocker.Where(l => l.shoes_index == index && l.shoes_number == number).ToList();
            }
            catch
            {
                return null;
            }
        }

        public ResultInfo IsShoesInUsed()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var shoes = db.Shoes.Where(x => x.shoes_number == this.shoes_number && x.shoes_index == this.shoes_index && x.shoes_type == shoes_type).FirstOrDefault();
                    if (shoes == null)
                    {
                        return new ResultInfo(Constants.ERROR_KEY_NOT_EXIST, "Chưa có tủ giày này!");
                    }
                    else if (shoes.owned != null && shoes.owned != owned)
                    {
                        return new ResultInfo(Constants.ERROR_KEY_USED, "Tủ giày đã có người sử dụng");
                    }
                    else
                    {
                        return new ResultInfo(Constants.SUCCESS, shoes.id.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new ResultInfo(Constants.COMMA, e.Message);
            }
        }
        public bool IsShoesExist()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var shoes = db.Shoes.Where(x => x.shoes_number == this.shoes_number && x.shoes_index == this.shoes_index && x.shoes_type == shoes_type).FirstOrDefault();
                    if (shoes == null)
                    {
                        return false;
                    }
                    else { return true; }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public ResultInfo Insert(Sho sho)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    Sho s = db.Shoes.Where(x => x.shoes_index == sho.shoes_index && x.shoes_number == sho.shoes_number && x.shoes_type == sho.shoes_type).FirstOrDefault();
                    if (s != null) return new ResultInfo(Constants.ERROR_DUPLICATE_DATA, "Tủ giày này đã có rồi");
                    sho.state = Constants.STATE_AVAIABLE;
                    db.Shoes.Add(sho);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, "");
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        internal ResultInfo UpdateOwned(Sho sho, int id)
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Shoes.Where(s => s.id == sho.id).FirstOrDefault<Sho>();
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

        public List<StaffEntity> GetHistory(int shoes_id)
        {
            try
            {
                using (UMCLOCKEREntities db = new UMCLOCKEREntities())
                {
                    List<StaffEntity> list = new List<StaffEntity>();
                    var lockerIdParameter = new SqlParameter("@shoes_id", shoes_id);
                    var result = db.Database
                        .SqlQuery<Staff>("history_shoes_key @shoes_id", lockerIdParameter)
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
