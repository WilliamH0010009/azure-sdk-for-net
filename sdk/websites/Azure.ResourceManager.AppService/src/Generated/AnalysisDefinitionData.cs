// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the AnalysisDefinition data model. </summary>
    public partial class AnalysisDefinitionData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of AnalysisDefinitionData. </summary>
        public AnalysisDefinitionData()
        {
        }

        /// <summary> Initializes a new instance of AnalysisDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="description"> Description of the Analysis. </param>
        internal AnalysisDefinitionData(ResourceIdentifier id, string name, ResourceType type, string kind, string description) : base(id, name, type, kind)
        {
            Description = description;
        }

        /// <summary> Description of the Analysis. </summary>
        public string Description { get; }
    }
}
