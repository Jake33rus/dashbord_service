using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardHelper.Models.Interfaces
{
    public interface IInfoRepository
    {
        Task<IEnumerable<FullInfo>> GetAllInfo();
        Task<FullInfo> GetInfo(string id);
        Task AddInfo(FullInfo item);
        //Task<DeleteResult> RemoveInfo(string id);
        //Task<UpdateResult> UpdateInfo(string id, string body);
    }
}
