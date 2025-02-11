// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Github access token for Appservice CLI github integration. </summary>
    public partial class AppServiceGithubToken
    {
        /// <summary> Initializes a new instance of AppServiceGithubToken. </summary>
        internal AppServiceGithubToken()
        {
        }

        /// <summary> Initializes a new instance of AppServiceGithubToken. </summary>
        /// <param name="accessToken"> Github access token for Appservice CLI github integration. </param>
        /// <param name="scope"> Scope of the github access token. </param>
        /// <param name="tokenType"> token type. </param>
        /// <param name="gotToken"> True if valid github token received, False otherwise. </param>
        /// <param name="errorMessage"> Error message if unable to get token. </param>
        internal AppServiceGithubToken(string accessToken, string scope, string tokenType, bool? gotToken, string errorMessage)
        {
            AccessToken = accessToken;
            Scope = scope;
            TokenType = tokenType;
            GotToken = gotToken;
            ErrorMessage = errorMessage;
        }

        /// <summary> Github access token for Appservice CLI github integration. </summary>
        public string AccessToken { get; }
        /// <summary> Scope of the github access token. </summary>
        public string Scope { get; }
        /// <summary> token type. </summary>
        public string TokenType { get; }
        /// <summary> True if valid github token received, False otherwise. </summary>
        public bool? GotToken { get; }
        /// <summary> Error message if unable to get token. </summary>
        public string ErrorMessage { get; }
    }
}
