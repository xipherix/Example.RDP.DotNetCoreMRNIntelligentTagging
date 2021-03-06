﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace IntelligentTagging.Model
{
    /// <summary>
    /// BasedElement is a generic class implement IMetaDat interface.
    /// It contains a share property for tag and entity class so we use this class to deserialize a based object.
    /// We use this class to check TypeGroup and Type of element and tag before deserialize the data to specific class.
    /// </summary>
    public class BaseElement : IMetaData
    {
        public string TypeGroup { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ForEndUserDisplay { get; set; }
        public IDictionary<string, JToken> _Attribute { get; set; }
        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"TypeGroup:{TypeGroup}\n");
            strBuilder.Append($"Type:{Type}\n");
            strBuilder.Append($"Name:{Name}\n");
            strBuilder.Append($"ForEndUserDisplay:{ForEndUserDisplay}\n");
            strBuilder.Append("===== Unhandled List ======\n");
            foreach (var item in _Attribute)
                strBuilder.Append($"{item.Key}:{item.Value}\n");
            strBuilder.Append("===========================\n");

            return strBuilder.ToString();
        }
    }
}