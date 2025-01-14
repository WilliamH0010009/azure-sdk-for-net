// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Appservice Github token request content. </summary>
    internal partial class AppserviceGithubTokenRequest
    {
        /// <summary> Initializes a new instance of AppserviceGithubTokenRequest. </summary>
        /// <param name="code"> Code string to exchange for Github Access token. </param>
        /// <param name="state"> State string used for verification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public AppserviceGithubTokenRequest(string code, string state)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            Code = code;
            State = state;
        }

        /// <summary> Code string to exchange for Github Access token. </summary>
        public string Code { get; }
        /// <summary> State string used for verification. </summary>
        public string State { get; }
    }
}
