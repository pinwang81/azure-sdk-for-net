﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The on-premises SQL Server database.
    /// </summary>
    [AdfTypeName("SqlServerTable")]
    public class SqlServerTableDataset : TableTypeProperties
    {
        /// <summary>
        /// The table name of the on-premises SQL database.
        /// </summary>
        [AdfRequired]
        public string TableName { get; set; }

        public SqlServerTableDataset()
        {
        }

        public SqlServerTableDataset(string tableName)
            : this()
        {
            Ensure.IsNotNullOrEmpty(tableName, "tableName");
            this.TableName = tableName;
        }
    }
}
