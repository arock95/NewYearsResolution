using NewYearsResolutionShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYearsResolutionAPI.DataAccess
{
    public class Resolutions : IResolutions
    {
        private readonly ResolutionsDbContext _db;
        public Resolutions(ResolutionsDbContext db)
        {
            _db = db;
        }
        public Resolution AddResolution(Resolution res)
        {
            var new_res = _db.Resolutions.Add(res).Entity;
            _db.SaveChanges();
            return new_res;
        }

        public LoggedMetric AddValue(Resolution res, LoggedMetric metric)
        {
            throw new NotImplementedException();
        }

        public bool DeleteResolution(Resolution res)
        {
            if (FindResolution(res) != null)
            {
                _db.Resolutions.Remove(res);
                return true;
            }
            return false;
        }

        public Resolution FindResolution(Resolution res)
        {
            return _db.Resolutions.FirstOrDefault(c => c.Id == res.Id);
        }

        public Resolution ModifyResolution(Resolution res)
        {
            var res_to_mod = FindResolution(res);
            if (res_to_mod != null)
            {
                res_to_mod.Metric = res.Metric;
                res_to_mod.Name = res.Name;
                res_to_mod.Timeframe = res.Timeframe;
                _db.SaveChanges();
                return res_to_mod;
            }
            else
            {
                return null;
            }
        }
    }
}
