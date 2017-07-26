#region Copyright ©2016, Click2Cloud Inc. - All Rights Reserved
/* ------------------------------------------------------------------- *
*                            Click2Cloud Inc.                          *
*                  Copyright ©2016 - All Rights reserved               *
*                                                                      *
* Apache 2.0 License                                                   *
* You may obtain a copy of the License at                              * 
* http://www.apache.org/licenses/LICENSE-2.0                           *
* Unless required by applicable law or agreed to in writing,           *
* software distributed under the License is distributed on an "AS IS"  *
* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express  *
* or implied. See the License for the specific language governing      *
* permissions and limitations under the License.                       *
*                                                                      *
* -------------------------------------------------------------------  */
#endregion Copyright ©2016, Click2Cloud Inc. - All Rights Reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnet_mysql_sample
{
    public static class ConnectionSetting
    {
        internal static string CONNECTION_STRING
        {
            get
            {
                if (!(string.IsNullOrEmpty(MYSQL_SERVICE_HOST) || string.IsNullOrEmpty(MYSQL_SERVICE_PORT)
                || string.IsNullOrEmpty(MYSQL_DATABASE) || string.IsNullOrEmpty(MYSQL_USER) || string.IsNullOrEmpty(MYSQL_PASSWORD)))
                {
                    string _connectionString = string.Format("server={0};port={1};database={2};uid={3};password={4};", MYSQL_SERVICE_HOST, MYSQL_SERVICE_PORT,
                        MYSQL_DATABASE, MYSQL_USER, MYSQL_PASSWORD);

                    return _connectionString;
                }
                else { throw new Exception("Environment variables are not configured"); }
            }
        }

        #region Get Environment Variables

        private static string MYSQL_SERVICE_HOST
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQL_SERVICE_HOST")))
                {
                    return Environment.GetEnvironmentVariable("MYSQL_SERVICE_HOST");
                }

                return string.Empty;
            }
        }

        private static string MYSQL_SERVICE_PORT
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQL_SERVICE_PORT")))
                {
                    return Environment.GetEnvironmentVariable("MYSQL_SERVICE_PORT");
                }

                return string.Empty;
            }
        }

        private static string MYSQL_DATABASE
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQL_DATABASE")))
                {
                    return Environment.GetEnvironmentVariable("MYSQL_DATABASE");
                }

                return string.Empty;
            }
        }

        private static string MYSQL_USER
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQL_USER")))
                {
                    return Environment.GetEnvironmentVariable("MYSQL_USER");
                }

                return string.Empty;
            }
        }

        private static string MYSQL_PASSWORD
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQL_PASSWORD")))
                {
                    return Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
                }

                return string.Empty;
            }
        }

        #endregion

    }
}
