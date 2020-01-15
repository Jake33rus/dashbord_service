
using DashboardHelper.Models;
using DashboardHelper.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardHelper.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        private readonly IInfoRepository _infoRepository;

        public InfoController(IInfoRepository infoRepository)
        {
            _infoRepository = infoRepository;
        }

        [HttpGet]
        public Task<IEnumerable<FullInfo>> Get()
        {
            return GetInfoInternal();
        }

        private async Task<IEnumerable<FullInfo>> GetInfoInternal()
        {
            return await _infoRepository.GetAllInfo();
        }

        [HttpGet("{id}")]
        public Task<FullInfo> Get(string id)
        {
            return GetInfoByInternal(id);
        }

        private async Task<FullInfo> GetInfoByInternal(string id)
        {
            return await _infoRepository.GetInfo(id) ?? new FullInfo();
        }

        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //    _infoRepository.AddInfo(new FullInfo() { Body = value, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now });
        //}
    }
}
