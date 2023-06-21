using SampleHierarchies.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data
{
    internal class Settings : ISettings
    {
        public string? Version { get; set; }
        public string? MainScreenColor { get; set; }
        public string? AnimalsScreenColor { get; set; }
        public string? MammalSpecies { get; set; } 
        public string? DogsScreenColor { get; set; }
    }
}
