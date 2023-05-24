﻿using easyNetAPI.Models;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyNetAPI.Models {
    public class Company
    {
        [BsonElement("company_id")]
        public int CompanyId { get; set; }
        [BsonElement("companyName")]
        public string? CompanyName { get; set; }
        [BsonElement("bot")]
        public Bot? Bot { get; set; }
    }
}
    
