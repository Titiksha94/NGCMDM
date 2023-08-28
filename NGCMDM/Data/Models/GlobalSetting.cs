using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NGCMDM.Data.Models
{
    public class GlobalSetting : BaseEntity
    {
        [Key]
        public Guid GUID { get; set; }
        public string? Name { get; set; }

        //Check for JSON Settings column
        public string? JsonSettingsColumn { get; set; }
        public string? Test { get; set; }


        //[NotMapped]
        // public JObject JsonSettings
        // {
        //     get
        //     {
        //         return JsonConvert.DeserializeObject<JObject>(string.IsNullOrEmpty(JsonSettingsColumn) ? "{}" : JsonSettingsColumn);
        //     }
        //     set
        //     {
        //         JsonSettingsColumn = value.ToString();
        //     }
        // }
    }
}
