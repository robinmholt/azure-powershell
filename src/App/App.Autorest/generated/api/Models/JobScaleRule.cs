// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Scaling rule.</summary>
    public partial class JobScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScaleRule,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScaleRuleInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuth> _auth;

        /// <summary>Authentication secrets for the scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuth> Auth { get => this._auth; set => this._auth = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny _metadata;

        /// <summary>Metadata properties to describe the scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Any()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Scale Rule Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// Type of the scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="JobScaleRule" /> instance.</summary>
        public JobScaleRule()
        {

        }
    }
    /// Scaling rule.
    public partial interface IJobScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Authentication secrets for the scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Authentication secrets for the scale rule.",
        SerializedName = @"auth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuth) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuth> Auth { get; set; }
        /// <summary>Metadata properties to describe the scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Metadata properties to describe the scale rule.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny Metadata { get; set; }
        /// <summary>Scale Rule Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Scale Rule Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Type of the scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the scale rule
        eg: azure-servicebus, redis etc.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Scaling rule.
    internal partial interface IJobScaleRuleInternal

    {
        /// <summary>Authentication secrets for the scale rule.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IScaleRuleAuth> Auth { get; set; }
        /// <summary>Metadata properties to describe the scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny Metadata { get; set; }
        /// <summary>Scale Rule Name</summary>
        string Name { get; set; }
        /// <summary>
        /// Type of the scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        string Type { get; set; }

    }
}