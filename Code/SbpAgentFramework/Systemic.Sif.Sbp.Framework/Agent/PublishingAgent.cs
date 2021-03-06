﻿/*
* Copyright 2011-2013 Systemic Pty Ltd
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*    http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software distributed under the License 
* is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
* or implied.
* See the License for the specific language governing permissions and limitations under the License.
*/

namespace Systemic.Sif.Sbp.Framework.Agent
{

    /// <summary>
    /// A publishing Agent that is simply based upon the SIF Common Framework.
    /// </summary>
    public abstract class PublishingAgent : Systemic.Sif.Framework.Agent.PublishingAgent
    {
        // Create a logger for use in this class.
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// This constructor will create a publishing Agent using the default "agent.cfg" file. If this configuration
        /// file does not exist, the Agent will not run when called.
        /// </summary>
        public PublishingAgent()
            : base()
        {
        }

        /// <summary>
        /// This constructor defines the configuration file associated with this Agent.
        /// </summary>
        /// <param name="cfgFileName">Configuration file associated with this Agent. If not provided, assumes "agent.cfg".</param>
        public PublishingAgent(string cfgFileName)
            : base(cfgFileName)
        {
        }

    }

}
