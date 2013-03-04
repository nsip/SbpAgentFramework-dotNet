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

using OpenADK.Library.au.Student;
using OpenADK.Library.Tools.Cfg;

namespace Systemic.Sif.Sbp.Framework.Publisher.Baseline
{

    /// <summary>
    /// A Publisher of StudentContactPersonal.
    /// </summary>
    public abstract class StudentContactPersonalPublisher : GenericPublisher<StudentContactPersonal>
    {

        /// <summary>
        /// Create an instance of the Publisher without referencing the Agent configuration settings.
        /// </summary>
        public StudentContactPersonalPublisher()
            : base()
        {
        }

        /// <summary>
        /// Create an instance of the Publisher based upon the Agent configuration settings.
        /// </summary>
        /// <param name="agentConfig">Agent configuration settings.</param>
        /// <exception cref="System.ArgumentException">agentConfig parameter is null.</exception>
        public StudentContactPersonalPublisher(AgentConfig agentConfig)
            : base(agentConfig)
        {
        }

    }

}
