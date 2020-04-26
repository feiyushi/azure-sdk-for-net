// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Imagebuilder.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents an output that was created by running an image template.
    /// </summary>
    [JsonTransformation]
    public partial class RunOutput : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the RunOutput class.
        /// </summary>
        public RunOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunOutput class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource type</param>
        /// <param name="artifactId">The resource id of the artifact.</param>
        /// <param name="artifactUri">The location URI of the artifact.</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Creating', 'Updating', 'Succeeded',
        /// 'Failed', 'Deleting'</param>
        public RunOutput(string name, string id = default(string), string type = default(string), string artifactId = default(string), string artifactUri = default(string), ProvisioningState? provisioningState = default(ProvisioningState?))
            : base(name, id, type)
        {
            ArtifactId = artifactId;
            ArtifactUri = artifactUri;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource id of the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifactId")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets the location URI of the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifactUri")]
        public string ArtifactUri { get; set; }

        /// <summary>
        /// Gets provisioning state of the resource. Possible values include:
        /// 'Creating', 'Updating', 'Succeeded', 'Failed', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
