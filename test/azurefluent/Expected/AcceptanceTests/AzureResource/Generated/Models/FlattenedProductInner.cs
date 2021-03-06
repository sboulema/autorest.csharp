// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureResource.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [JsonTransformation]
    public partial class FlattenedProductInner : Microsoft.Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the FlattenedProductInner class.
        /// </summary>
        public FlattenedProductInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlattenedProductInner class.
        /// </summary>
        public FlattenedProductInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string pname = default(string), int? lsize = default(int?), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            Pname = pname;
            Lsize = lsize;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.pname")]
        public string Pname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.lsize")]
        public int? Lsize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
