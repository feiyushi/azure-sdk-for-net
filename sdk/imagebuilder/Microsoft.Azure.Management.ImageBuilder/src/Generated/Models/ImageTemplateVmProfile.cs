// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ImageBuilder.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the virtual machine used to build, customize and capture
    /// images
    /// </summary>
    public partial class ImageTemplateVmProfile
    {
        /// <summary>
        /// Initializes a new instance of the ImageTemplateVmProfile class.
        /// </summary>
        public ImageTemplateVmProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageTemplateVmProfile class.
        /// </summary>
        /// <param name="vmSize">Size of the virtual machine used to build,
        /// customize and capture images. Omit or specify empty string to use
        /// the default (Standard_D1_v2).</param>
        /// <param name="osDiskSizeGB">Size of the OS disk in GB. Omit or
        /// specify 0 to use Azure's default OS disk size.</param>
        /// <param name="vnetConfig">Optional configuration of the virtual
        /// network to use to deploy the build virtual machine in. Omit if no
        /// specific virtual network needs to be used.</param>
        public ImageTemplateVmProfile(string vmSize = default(string), int? osDiskSizeGB = default(int?), VirtualNetworkConfig vnetConfig = default(VirtualNetworkConfig))
        {
            VmSize = vmSize;
            OsDiskSizeGB = osDiskSizeGB;
            VnetConfig = vnetConfig;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets size of the virtual machine used to build, customize
        /// and capture images. Omit or specify empty string to use the default
        /// (Standard_D1_v2).
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets size of the OS disk in GB. Omit or specify 0 to use
        /// Azure's default OS disk size.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskSizeGB")]
        public int? OsDiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets optional configuration of the virtual network to use
        /// to deploy the build virtual machine in. Omit if no specific virtual
        /// network needs to be used.
        /// </summary>
        [JsonProperty(PropertyName = "vnetConfig")]
        public VirtualNetworkConfig VnetConfig { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OsDiskSizeGB < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "OsDiskSizeGB", 0);
            }
        }
    }
}
