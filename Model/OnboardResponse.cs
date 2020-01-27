﻿#region copyright
// This work is licensed under the Creative Commons Attribution-ShareAlike 4.0 International License. 
// To view a copy of this license, visit http://creativecommons.org/licenses/by-sa/4.0/ or send a letter 
// to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
#endregion copyright

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class OnboardResponse
    {
        [JsonProperty]
        public string Character { get; set; }

        [JsonProperty]
        public List<Command> Commands { get; set; }

        [JsonProperty]
        public int Table { get; set; }
    }
}
