using Scanner.Systems.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanner.Systems.Core.Abstractions
{
    public interface ISystemConfigurationService
    {
        public Task<CPUInfo> GetCpuInfo();
        public Task<GraphicsInfo> GetGraphicsInfo();
        public Task<SystemInfo> GetSystemInfo();
    }
}
