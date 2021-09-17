using SuperHero.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Domain.Models
{
    public class ApiModel
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Etag { get; set; }
        public DataApiModel[] Data { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }
    }
}
