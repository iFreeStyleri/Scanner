using Scanner.Systems.Core.Abstractions;
using Scanner.Systems.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Scanner.Systems.Core.Implementations
{
    public class SystemConfigurationService : ISystemConfigurationService
    {
        public async Task<CPUInfo> GetCpuInfo()
        {
            return await Task.Run(() =>
            {
                return new CPUInfo
                {
                    CpuCount = Environment.ProcessorCount
                };
            });
        }

        public Task<GraphicsInfo> GetGraphicsInfo()
        {
            throw new Exception();
        }

        public Task<SystemInfo> GetSystemInfo()
        {
            throw new Exception();
        }
        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
