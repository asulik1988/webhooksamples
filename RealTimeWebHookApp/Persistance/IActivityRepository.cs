using System;
using System.Collections.Generic;
using RealTimeWebHookApp.Models;

namespace RealTimeWebHookApp.Persistance
{
    public interface IActivityRepository : IDisposable
    {
        ActivityModel Add(ActivityModel activityModel);
        IEnumerable<ActivityModel> GetAll();
        ActivityModel GetBy(int activityId);
    }
}