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
    /// A REST API operation
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">The operation name.</param>
        /// <param name="display">The object that describes the
        /// operation.</param>
        /// <param name="origin">The intended executor of the
        /// operation.</param>
        /// <param name="properties">Properties of the operation.</param>
        /// <param name="isDataAction">The flag that indicates whether the
        /// operation applies to data plane.</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay), string origin = default(string), object properties = default(object), bool? isDataAction = default(bool?))
        {
            Name = name;
            Display = display;
            Origin = origin;
            Properties = properties;
            IsDataAction = isDataAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operation name.
        /// </summary>
        /// <remarks>
        /// This is of the format {provider}/{resource}/{operation}
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the object that describes the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets the intended executor of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets properties of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether the operation applies
        /// to data plane.
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

    }
}
