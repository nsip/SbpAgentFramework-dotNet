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

using OpenADK.Library;
using OpenADK.Library.au.School;
using Systemic.Sif.Framework.Publisher;

namespace Systemic.Sif.Sbp.Demo.Publishing.XmlString
{

    /// <summary>
    /// Publisher of SchoolInfo SIF Data Objects.
    /// </summary>
    class SchoolInfoPublisher : Systemic.Sif.Sbp.Framework.Publisher.Baseline.SchoolInfoPublisher
    {

        /// <summary>
        /// Return an iterator of events for the SchoolInfo SIF Data Object.
        /// </summary>
        /// <returns>Iterator of events for the SchoolInfo SIF Data Object.</returns>
        public override ISifEventIterator<SchoolInfo> GetSifEvents()
        {
            return new SchoolInfoIterator();
        }

        /// <summary>
        /// Return an iterator of responses for the SchoolInfo SIF Data Object.
        /// </summary>
        /// <param name="query">Specific query to be executed.</param>
        /// <param name="zone">Zone to use.</param>
        /// <returns>Iterator of responses for the SchoolInfo SIF Data Object.</returns>
        public override ISifResponseIterator<SchoolInfo> GetSifResponses(Query query, IZone zone)
        {
            return new SchoolInfoIterator();
        }

    }

}
