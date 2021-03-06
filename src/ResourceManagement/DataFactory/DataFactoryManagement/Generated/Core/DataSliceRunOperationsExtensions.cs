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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Core;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Core
{
    public static partial class DataSliceRunOperationsExtensions
    {
        /// <summary>
        /// Gets a Data Slice Run instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='runId'>
        /// Required. A unique Data Slice Run Id.
        /// </param>
        /// <returns>
        /// The get Data Slice Run operation response.
        /// </returns>
        public static DataSliceRunGetResponse Get(this IDataSliceRunOperations operations, string resourceGroupName, string dataFactoryName, string runId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSliceRunOperations)s).GetAsync(resourceGroupName, dataFactoryName, runId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a Data Slice Run instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='runId'>
        /// Required. A unique Data Slice Run Id.
        /// </param>
        /// <returns>
        /// The get Data Slice Run operation response.
        /// </returns>
        public static Task<DataSliceRunGetResponse> GetAsync(this IDataSliceRunOperations operations, string resourceGroupName, string dataFactoryName, string runId)
        {
            return operations.GetAsync(resourceGroupName, dataFactoryName, runId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets logs for a data slice run
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='dataSliceRunId'>
        /// Required. A unique data slice run instance id.
        /// </param>
        /// <returns>
        /// The data slice run get logs operation response.
        /// </returns>
        public static DataSliceRunGetLogsResponse GetLogs(this IDataSliceRunOperations operations, string resourceGroupName, string dataFactoryName, string dataSliceRunId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSliceRunOperations)s).GetLogsAsync(resourceGroupName, dataFactoryName, dataSliceRunId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets logs for a data slice run
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='dataSliceRunId'>
        /// Required. A unique data slice run instance id.
        /// </param>
        /// <returns>
        /// The data slice run get logs operation response.
        /// </returns>
        public static Task<DataSliceRunGetLogsResponse> GetLogsAsync(this IDataSliceRunOperations operations, string resourceGroupName, string dataFactoryName, string dataSliceRunId)
        {
            return operations.GetLogsAsync(resourceGroupName, dataFactoryName, dataSliceRunId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the first page of data slice run instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters for specifying the filters to list data slice
        /// runs of the table.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static DataSliceRunListResponse List(this IDataSliceRunOperations operations, string resourceGroupName, string dataFactoryName, string tableName, DataSliceRunListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSliceRunOperations)s).ListAsync(resourceGroupName, dataFactoryName, tableName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of data slice run instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters for specifying the filters to list data slice
        /// runs of the table.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static Task<DataSliceRunListResponse> ListAsync(this IDataSliceRunOperations operations, string resourceGroupName, string dataFactoryName, string tableName, DataSliceRunListParameters parameters)
        {
            return operations.ListAsync(resourceGroupName, dataFactoryName, tableName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of run instances with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next data slice runs page.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static DataSliceRunListResponse ListNext(this IDataSliceRunOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSliceRunOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of run instances with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next data slice runs page.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static Task<DataSliceRunListResponse> ListNextAsync(this IDataSliceRunOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
