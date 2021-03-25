namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class ResourceTypeRequestHeaderOptions :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IResourceTypeRequestHeaderOptions,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IResourceTypeRequestHeaderOptionsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IRequestHeaderOptions"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IRequestHeaderOptions __requestHeaderOptions = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.RequestHeaderOptions();

        [Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.PropertyOrigin.Inherited)]
        public string OptInHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IRequestHeaderOptionsInternal)__requestHeaderOptions).OptInHeader; set => ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IRequestHeaderOptionsInternal)__requestHeaderOptions).OptInHeader = value; }

        /// <summary>Creates an new <see cref="ResourceTypeRequestHeaderOptions" /> instance.</summary>
        public ResourceTypeRequestHeaderOptions()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__requestHeaderOptions), __requestHeaderOptions);
            await eventListener.AssertObjectIsValid(nameof(__requestHeaderOptions), __requestHeaderOptions);
        }
    }
    public partial interface IResourceTypeRequestHeaderOptions :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IRequestHeaderOptions
    {

    }
    internal partial interface IResourceTypeRequestHeaderOptionsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IRequestHeaderOptionsInternal
    {

    }
}