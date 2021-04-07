using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMCLocker.Business;

namespace UMCLocker.Entities
{
    public class DeptEntity : Dept, IModelEntities
    {
        public int index { get; set; }
        public DeptEntity() { }
        public DeptEntity(string name)
        {
            this.name = name;
        }

        public DeptEntity(int id, string name, int index)
        {
            this.id = id;
            this.name = name;
            this.index = index;
        }

        public DeptEntity(Dept dept)
        {
            this.id = dept.id;
            this.name = dept.name;
        }
        public ResultInfo Insert()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    Dept dept = new Dept();
                    dept.name = name;
                    db.Depts.Add(dept);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, dept.id.ToString());
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public IEnumerable GetAllData()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    List<Dept> depts = db.Depts.ToList();
                    List<DeptEntity> list = depts.Select((x, i) => new DeptEntity
                    {
                        index = i + 1,
                        name = x.name,
                        id = x.id
                    }).ToList();
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public ResultInfo Update()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var update = db.Depts.Where(d => d.id == this.id).FirstOrDefault<Dept>();
                    update.name = this.name;
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, update.id.ToString());
                }

            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public ResultInfo Delete()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    var delete = db.Depts.Where(d => d.id == this.id).FirstOrDefault<Dept>();
                    db.Depts.Remove(delete);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, delete.id.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new ResultInfo(Constants.ERROR_COMMON, ex.Message.ToString());
            }
        }

        public static List<Dept> FilterByName(List<Dept> depts, string name)
        {
            try
            {
                return depts = depts.Where(d => d.name.ToLower().Contains(name.ToLower())).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}

