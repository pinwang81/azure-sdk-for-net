// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// Details of publishing / unpublishing operation results
    /// </summary>
    public partial class PublishingOperationResult
    {
        private string _applicationAlias;
        
        /// <summary>
        /// Optional. The application alias.
        /// </summary>
        public string ApplicationAlias
        {
            get { return this._applicationAlias; }
            set { this._applicationAlias = value; }
        }
        
        private string _applicationVirtualPath;
        
        /// <summary>
        /// Optional. The application virtual path with respect to local
        /// machine.
        /// </summary>
        public string ApplicationVirtualPath
        {
            get { return this._applicationVirtualPath; }
            set { this._applicationVirtualPath = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error message with respect to operation result.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private bool _success;
        
        /// <summary>
        /// Optional. Whether operation was successful.
        /// </summary>
        public bool Success
        {
            get { return this._success; }
            set { this._success = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PublishingOperationResult class.
        /// </summary>
        public PublishingOperationResult()
        {
        }
    }
}
