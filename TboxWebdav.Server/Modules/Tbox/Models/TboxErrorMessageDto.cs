﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TboxWebdav.Server.Modules.Tbox.Models
{
    public class TboxErrorMessageDto
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
