// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a project
    /// </summary>
    public partial class Project
    {
        /// <summary>
        /// Initializes a new instance of the Project class.
        /// </summary>
        public Project()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Project class.
        /// </summary>
        /// <param name="id">Gets the project id</param>
        /// <param name="name">Gets or sets the name of the project</param>
        /// <param name="description">Gets or sets the description of the
        /// project</param>
        /// <param name="settings">Gets or sets the project settings</param>
        /// <param name="currentIterationId">Gets the current iteration
        /// id</param>
        /// <param name="created">Gets the date this project was
        /// created</param>
        /// <param name="lastModified">Gets the date this project was last
        /// modifed</param>
        /// <param name="thumbnailUri">Gets the thumbnail url representing the
        /// image</param>
        public Project(System.Guid id = default(System.Guid), string name = default(string), string description = default(string), ProjectSettings settings = default(ProjectSettings), System.Guid? currentIterationId = default(System.Guid?), System.DateTime created = default(System.DateTime), System.DateTime lastModified = default(System.DateTime), string thumbnailUri = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Settings = settings;
            CurrentIterationId = currentIterationId;
            Created = created;
            LastModified = lastModified;
            ThumbnailUri = thumbnailUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the project id
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// Gets or sets the name of the project
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the project
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the project settings
        /// </summary>
        [JsonProperty(PropertyName = "Settings")]
        public ProjectSettings Settings { get; set; }

        /// <summary>
        /// Gets the current iteration id
        /// </summary>
        [JsonProperty(PropertyName = "CurrentIterationId")]
        public System.Guid? CurrentIterationId { get; private set; }

        /// <summary>
        /// Gets the date this project was created
        /// </summary>
        [JsonProperty(PropertyName = "Created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets the date this project was last modifed
        /// </summary>
        [JsonProperty(PropertyName = "LastModified")]
        public System.DateTime LastModified { get; private set; }

        /// <summary>
        /// Gets the thumbnail url representing the image
        /// </summary>
        [JsonProperty(PropertyName = "ThumbnailUri")]
        public string ThumbnailUri { get; private set; }

    }
}
