/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;
using System.Collections.Generic;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class DescribeDcdnDomainOriginBpsDataRequest : RpcAcsRequest<DescribeDcdnDomainOriginBpsDataResponse>
    {
        public DescribeDcdnDomainOriginBpsDataRequest()
            : base("dcdn", "2018-01-15", "DescribeDcdnDomainOriginBpsData")
        {
        }

		private string startTime;

		private string action;

		private string fixTimeGap;

		private string timeMerge;

		private string domainName;

		private string endTime;

		private long? ownerId;

		private string interval;

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string FixTimeGap
		{
			get
			{
				return fixTimeGap;
			}
			set	
			{
				fixTimeGap = value;
				DictionaryUtil.Add(QueryParameters, "FixTimeGap", value);
			}
		}

		public string TimeMerge
		{
			get
			{
				return timeMerge;
			}
			set	
			{
				timeMerge = value;
				DictionaryUtil.Add(QueryParameters, "TimeMerge", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value);
			}
		}

        public override DescribeDcdnDomainOriginBpsDataResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDcdnDomainOriginBpsDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}