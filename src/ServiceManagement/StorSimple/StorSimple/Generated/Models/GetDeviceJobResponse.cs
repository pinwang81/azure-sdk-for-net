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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Response model of Get Query for a Device Job
    /// </summary>
    public partial class GetDeviceJobResponse : AzureOperationResponse
    {
        private int _count;
        
        /// <summary>
        /// Optional. Count of results
        /// </summary>
        public int Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private IList<DeviceJobDetails> _deviceJobList;
        
        /// <summary>
        /// Optional. Device Job details of jobs in response
        /// </summary>
        public IList<DeviceJobDetails> DeviceJobList
        {
            get { return this._deviceJobList; }
            set { this._deviceJobList = value; }
        }
        
        private string _nextPageStartIdentifier;
        
        /// <summary>
        /// Optional. An Id identifying start of the next page
        /// </summary>
        public string NextPageStartIdentifier
        {
            get { return this._nextPageStartIdentifier; }
            set { this._nextPageStartIdentifier = value; }
        }
        
        private string _nextPageUri;
        
        /// <summary>
        /// Optional. Url for next page. Will be null for last page
        /// </summary>
        public string NextPageUri
        {
            get { return this._nextPageUri; }
            set { this._nextPageUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GetDeviceJobResponse class.
        /// </summary>
        public GetDeviceJobResponse()
        {
            this.DeviceJobList = new LazyList<DeviceJobDetails>();
        }
    }
}
