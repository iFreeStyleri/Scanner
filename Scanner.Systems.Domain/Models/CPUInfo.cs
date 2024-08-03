using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanner.Systems.Domain.Models
{
    public partial class CPUInfo : ObservableObject
    {
        [ObservableProperty] private string _name;
        [ObservableProperty] private string _codeName;
        [ObservableProperty] private string _specification;
        [ObservableProperty] private string _instructions;
        [ObservableProperty] private string _technology;
        [ObservableProperty] private int _cpuCount;
    }
}
