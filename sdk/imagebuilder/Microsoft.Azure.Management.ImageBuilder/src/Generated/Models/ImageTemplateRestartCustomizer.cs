// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Imagebuilder.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reboots a VM and waits for it to come back online (Windows).
    /// Corresponds to Packer windows-restart provisioner
    /// </summary>
    [Newtonsoft.Json.JsonObject("WindowsRestart")]
    public partial class ImageTemplateRestartCustomizer : ImageTemplateCustomizer
    {
        /// <summary>
        /// Initializes a new instance of the ImageTemplateRestartCustomizer
        /// class.
        /// </summary>
        public ImageTemplateRestartCustomizer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageTemplateRestartCustomizer
        /// class.
        /// </summary>
        /// <param name="name">Friendly Name to provide context on what this
        /// customization step does</param>
        /// <param name="restartCommand">Command to execute the restart
        /// [Default: 'shutdown /r /f /t 0 /c "packer restart"']</param>
        /// <param name="restartCheckCommand">Command to check if restart
        /// succeeded [Default: '']</param>
        /// <param name="restartTimeout">Restart timeout specified as a string
        /// of magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours)
        /// [Default: '5m']</param>
        public ImageTemplateRestartCustomizer(string name = default(string), string restartCommand = default(string), string restartCheckCommand = default(string), string restartTimeout = default(string))
            : base(name)
        {
            RestartCommand = restartCommand;
            RestartCheckCommand = restartCheckCommand;
            RestartTimeout = restartTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command to execute the restart [Default: 'shutdown /r
        /// /f /t 0 /c "packer restart"']
        /// </summary>
        [JsonProperty(PropertyName = "restartCommand")]
        public string RestartCommand { get; set; }

        /// <summary>
        /// Gets or sets command to check if restart succeeded [Default: '']
        /// </summary>
        [JsonProperty(PropertyName = "restartCheckCommand")]
        public string RestartCheckCommand { get; set; }

        /// <summary>
        /// Gets or sets restart timeout specified as a string of magnitude and
        /// unit, e.g. '5m' (5 minutes) or '2h' (2 hours) [Default: '5m']
        /// </summary>
        [JsonProperty(PropertyName = "restartTimeout")]
        public string RestartTimeout { get; set; }

    }
}
