// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support
{

    /// <summary>Argument completer implementation for RoutingType.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.RoutingTypeTypeConverter))]
    public partial struct RoutingType :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Default".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Default", "Default", global::System.Management.Automation.CompletionResultType.ParameterValue, "Default");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ProxyOnly".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ProxyOnly", "ProxyOnly", global::System.Management.Automation.CompletionResultType.ParameterValue, "ProxyOnly");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "HostBased".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("HostBased", "HostBased", global::System.Management.Automation.CompletionResultType.ParameterValue, "HostBased");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Extension".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Extension", "Extension", global::System.Management.Automation.CompletionResultType.ParameterValue, "Extension");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Tenant".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Tenant", "Tenant", global::System.Management.Automation.CompletionResultType.ParameterValue, "Tenant");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Fanout".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Fanout", "Fanout", global::System.Management.Automation.CompletionResultType.ParameterValue, "Fanout");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LocationBased".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("LocationBased", "LocationBased", global::System.Management.Automation.CompletionResultType.ParameterValue, "LocationBased");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failover".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Failover", "Failover", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failover");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CascadeExtension".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CascadeExtension", "CascadeExtension", global::System.Management.Automation.CompletionResultType.ParameterValue, "CascadeExtension");
            }
        }
    }
}