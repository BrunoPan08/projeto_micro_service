using System.Collections;
using System.Collections.Generic;
using PlatformServiceV2.Models;

namespace PlatformServiceV2.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}