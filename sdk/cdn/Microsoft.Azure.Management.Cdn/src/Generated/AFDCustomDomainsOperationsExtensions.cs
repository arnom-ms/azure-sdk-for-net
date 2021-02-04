// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AFDCustomDomainsOperations.
    /// </summary>
    public static partial class AFDCustomDomainsOperationsExtensions
    {
            /// <summary>
            /// Lists existing AzureFrontDoor domains.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            public static IPage<AFDDomain> ListByProfile(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName)
            {
                return operations.ListByProfileAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor domains.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AFDDomain>> ListByProfileAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProfileWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing AzureFrontDoor domain with the specified domain name under
            /// the specified subscription, resource group and profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            public static AFDDomain Get(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName)
            {
                return operations.GetAsync(resourceGroupName, profileName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing AzureFrontDoor domain with the specified domain name under
            /// the specified subscription, resource group and profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDDomain> GetAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new domain within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='customDomain'>
            /// Domain properties
            /// </param>
            public static AFDDomain Create(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomain customDomain)
            {
                return operations.CreateAsync(resourceGroupName, profileName, customDomainName, customDomain).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new domain within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='customDomain'>
            /// Domain properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDDomain> CreateAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomain customDomain, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, customDomain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing domain within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='tlsSettings'>
            /// The configuration specifying how to enable HTTPS for the domain - using
            /// AzureFrontDoor managed certificate or user's own certificate. If not
            /// specified, enabling ssl uses AzureFrontDoor managed certificate by default.
            /// </param>
            /// <param name='azureDnsZone'>
            /// Resource reference to the Azure DNS zone
            /// </param>
            public static AFDDomain Update(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomainHttpsParameters tlsSettings = default(AFDDomainHttpsParameters), ResourceReference azureDnsZone = default(ResourceReference))
            {
                return operations.UpdateAsync(resourceGroupName, profileName, customDomainName, tlsSettings, azureDnsZone).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing domain within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='tlsSettings'>
            /// The configuration specifying how to enable HTTPS for the domain - using
            /// AzureFrontDoor managed certificate or user's own certificate. If not
            /// specified, enabling ssl uses AzureFrontDoor managed certificate by default.
            /// </param>
            /// <param name='azureDnsZone'>
            /// Resource reference to the Azure DNS zone
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDDomain> UpdateAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomainHttpsParameters tlsSettings = default(AFDDomainHttpsParameters), ResourceReference azureDnsZone = default(ResourceReference), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, tlsSettings, azureDnsZone, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor domain with the specified domain name
            /// under the specified subscription, resource group and profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            public static void Delete(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName)
            {
                operations.DeleteAsync(resourceGroupName, profileName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor domain with the specified domain name
            /// under the specified subscription, resource group and profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the domain validation token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            public static ValidationToken RefreshValidationToken(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName)
            {
                return operations.RefreshValidationTokenAsync(resourceGroupName, profileName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the domain validation token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValidationToken> RefreshValidationTokenAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RefreshValidationTokenWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new domain within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='customDomain'>
            /// Domain properties
            /// </param>
            public static AFDDomain BeginCreate(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomain customDomain)
            {
                return operations.BeginCreateAsync(resourceGroupName, profileName, customDomainName, customDomain).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new domain within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='customDomain'>
            /// Domain properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDDomain> BeginCreateAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomain customDomain, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, customDomain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing domain within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='tlsSettings'>
            /// The configuration specifying how to enable HTTPS for the domain - using
            /// AzureFrontDoor managed certificate or user's own certificate. If not
            /// specified, enabling ssl uses AzureFrontDoor managed certificate by default.
            /// </param>
            /// <param name='azureDnsZone'>
            /// Resource reference to the Azure DNS zone
            /// </param>
            public static AFDDomain BeginUpdate(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomainHttpsParameters tlsSettings = default(AFDDomainHttpsParameters), ResourceReference azureDnsZone = default(ResourceReference))
            {
                return operations.BeginUpdateAsync(resourceGroupName, profileName, customDomainName, tlsSettings, azureDnsZone).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing domain within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally
            /// </param>
            /// <param name='tlsSettings'>
            /// The configuration specifying how to enable HTTPS for the domain - using
            /// AzureFrontDoor managed certificate or user's own certificate. If not
            /// specified, enabling ssl uses AzureFrontDoor managed certificate by default.
            /// </param>
            /// <param name='azureDnsZone'>
            /// Resource reference to the Azure DNS zone
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDDomain> BeginUpdateAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, AFDDomainHttpsParameters tlsSettings = default(AFDDomainHttpsParameters), ResourceReference azureDnsZone = default(ResourceReference), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, tlsSettings, azureDnsZone, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor domain with the specified domain name
            /// under the specified subscription, resource group and profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            public static void BeginDelete(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName)
            {
                operations.BeginDeleteAsync(resourceGroupName, profileName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor domain with the specified domain name
            /// under the specified subscription, resource group and profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the domain validation token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            public static ValidationToken BeginRefreshValidationToken(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName)
            {
                return operations.BeginRefreshValidationTokenAsync(resourceGroupName, profileName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the domain validation token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the domain under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValidationToken> BeginRefreshValidationTokenAsync(this IAFDCustomDomainsOperations operations, string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRefreshValidationTokenWithHttpMessagesAsync(resourceGroupName, profileName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists existing AzureFrontDoor domains.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AFDDomain> ListByProfileNext(this IAFDCustomDomainsOperations operations, string nextPageLink)
            {
                return operations.ListByProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor domains.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AFDDomain>> ListByProfileNextAsync(this IAFDCustomDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
