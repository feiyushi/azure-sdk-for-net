// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ImageBuilder.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Runs the specified PowerShell on the VM (Windows). Corresponds to
    /// Packer powershell provisioner. Exactly one of 'scriptUri' or 'inline'
    /// can be specified.
    /// </summary>
    [Newtonsoft.Json.JsonObject("PowerShell")]
    public partial class ImageTemplatePowerShellCustomizer : ImageTemplateCustomizer
    {
        /// <summary>
        /// Initializes a new instance of the ImageTemplatePowerShellCustomizer
        /// class.
        /// </summary>
        public ImageTemplatePowerShellCustomizer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageTemplatePowerShellCustomizer
        /// class.
        /// </summary>
        /// <param name="name">Friendly Name to provide context on what this
        /// customization step does</param>
        /// <param name="scriptUri">URI of the PowerShell script to be run for
        /// customizing. It can be a github link, SAS URI for Azure Storage,
        /// etc</param>
        /// <param name="sha256Checksum">SHA256 checksum of the power shell
        /// script provided in the scriptUri field above</param>
        /// <param name="inline">Array of PowerShell commands to
        /// execute</param>
        /// <param name="runElevated">If specified, the PowerShell script will
        /// be run with elevated privileges</param>
        /// <param name="runAsSystem">If specified, the PowerShell script will
        /// be run with elevated privileges using the Local System user. Can
        /// only be true when the runElevated field above is set to
        /// true.</param>
        /// <param name="validExitCodes">Valid exit codes for the PowerShell
        /// script. [Default: 0]</param>
        public ImageTemplatePowerShellCustomizer(string name = default(string), string scriptUri = default(string), string sha256Checksum = default(string), IList<string> inline = default(IList<string>), bool? runElevated = default(bool?), bool? runAsSystem = default(bool?), IList<int?> validExitCodes = default(IList<int?>))
            : base(name)
        {
            ScriptUri = scriptUri;
            Sha256Checksum = sha256Checksum;
            Inline = inline;
            RunElevated = runElevated;
            RunAsSystem = runAsSystem;
            ValidExitCodes = validExitCodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URI of the PowerShell script to be run for
        /// customizing. It can be a github link, SAS URI for Azure Storage,
        /// etc
        /// </summary>
        [JsonProperty(PropertyName = "scriptUri")]
        public string ScriptUri { get; set; }

        /// <summary>
        /// Gets or sets SHA256 checksum of the power shell script provided in
        /// the scriptUri field above
        /// </summary>
        [JsonProperty(PropertyName = "sha256Checksum")]
        public string Sha256Checksum { get; set; }

        /// <summary>
        /// Gets or sets array of PowerShell commands to execute
        /// </summary>
        [JsonProperty(PropertyName = "inline")]
        public IList<string> Inline { get; set; }

        /// <summary>
        /// Gets or sets if specified, the PowerShell script will be run with
        /// elevated privileges
        /// </summary>
        [JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// Gets or sets if specified, the PowerShell script will be run with
        /// elevated privileges using the Local System user. Can only be true
        /// when the runElevated field above is set to true.
        /// </summary>
        [JsonProperty(PropertyName = "runAsSystem")]
        public bool? RunAsSystem { get; set; }

        /// <summary>
        /// Gets or sets valid exit codes for the PowerShell script. [Default:
        /// 0]
        /// </summary>
        [JsonProperty(PropertyName = "validExitCodes")]
        public IList<int?> ValidExitCodes { get; set; }

    }
}
