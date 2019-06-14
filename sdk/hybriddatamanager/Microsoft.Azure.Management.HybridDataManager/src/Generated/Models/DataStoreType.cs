// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data Store Type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataStoreType : DmsBaseObject
    {
        /// <summary>
        /// Initializes a new instance of the DataStoreType class.
        /// </summary>
        public DataStoreType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStoreType class.
        /// </summary>
        /// <param name="state">State of the data store type. Possible values
        /// include: 'Disabled', 'Enabled', 'Supported'</param>
        /// <param name="name">Name of the object.</param>
        /// <param name="id">Id of the object.</param>
        /// <param name="type">Type of the object.</param>
        /// <param name="repositoryType">Arm type for the manager resource to
        /// which the data source type is associated. This is optional.</param>
        /// <param name="supportedDataServicesAsSink">Supported data services
        /// where it can be used as a sink.</param>
        /// <param name="supportedDataServicesAsSource">Supported data services
        /// where it can be used as a source.</param>
        public DataStoreType(State state, string name = default(string), string id = default(string), string type = default(string), string repositoryType = default(string), IList<string> supportedDataServicesAsSink = default(IList<string>), IList<string> supportedDataServicesAsSource = default(IList<string>))
            : base(name, id, type)
        {
            RepositoryType = repositoryType;
            State = state;
            SupportedDataServicesAsSink = supportedDataServicesAsSink;
            SupportedDataServicesAsSource = supportedDataServicesAsSource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets arm type for the manager resource to which the data
        /// source type is associated. This is optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties.repositoryType")]
        public string RepositoryType { get; set; }

        /// <summary>
        /// Gets or sets state of the data store type. Possible values include:
        /// 'Disabled', 'Enabled', 'Supported'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public State State { get; set; }

        /// <summary>
        /// Gets or sets supported data services where it can be used as a
        /// sink.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportedDataServicesAsSink")]
        public IList<string> SupportedDataServicesAsSink { get; set; }

        /// <summary>
        /// Gets or sets supported data services where it can be used as a
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportedDataServicesAsSource")]
        public IList<string> SupportedDataServicesAsSource { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}