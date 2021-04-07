using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMCLocker.Business;

namespace UMCLocker.Entities
{
    public class PosEntity : Pos, IModelEntities
    {

        public PosEntity() { }
        public PosEntity(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public PosEntity(string name)
        {
            this.name = name;
        }
        public int index { get; set; }
        public ResultInfo Insert()
        {
            try
            {
                using (var db = new UMCLOCKEREntities())
                {
                    Pos p = new Pos();
                    p.name = name;
                    db.Pos.Add(p);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, p.id.ToString());
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
                    List<Pos> depts = db.Pos.ToList();
                    List<PosEntity> list = depts.Select((x, i) => new PosEntity
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
                    var update = db.Pos.Where(d => d.id == this.id).FirstOrDefault<Pos>();
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
                    var delete = db.Pos.Where(d => d.id == this.id).FirstOrDefault<Pos>();
                    db.Pos.Remove(delete);
                    db.SaveChanges();
                    return new ResultInfo(Constants.SUCCESS, delete.id.ToString());
                }
            }
            catch (Exception e)
            {
                return new ResultInfo(Constants.ERROR_COMMON, e.Message.ToString());
            }
        }

        public static List<PosEntity> FilterByName(List<PosEntity> pos, string name)
        {
            try
            {
                return pos.Where(p => p.name.ToLower().Contains(name.ToLower())).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
