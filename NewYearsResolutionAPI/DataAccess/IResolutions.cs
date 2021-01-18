using NewYearsResolutionShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYearsResolutionAPI.DataAccess
{
    interface IResolutions
    {
        Resolution AddResolution(Resolution res);

        Resolution ModifyResolution(Resolution res);

        bool DeleteResolution(Resolution res);

        Resolution FindResolution(Resolution res);

        LoggedMetric AddValue(Resolution res, LoggedMetric metric);
    }
}
