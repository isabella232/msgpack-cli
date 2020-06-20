﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using ProtoBuf;

namespace Benchmark.Models
{
    [ProtoContract, System.Serializable, System.Runtime.Serialization.DataContract, MessagePack.MessagePackObject]
    public class Error : IGenericEquality<Error>
    {
        [System.Runtime.Serialization.DataMember, ProtoMember(1), MessagePack.Key(1 - 1)]
        public int? error_id { get; set; }

        [System.Runtime.Serialization.DataMember, ProtoMember(2), MessagePack.Key(2 - 1)]
        public string error_name { get; set; }

        [System.Runtime.Serialization.DataMember, ProtoMember(3), MessagePack.Key(3 - 1)]
        public string description { get; set; }

        public bool Equals(Error obj)
        {
            return
                this.error_id.TrueEquals(obj.error_id) &&
                this.error_name.TrueEqualsString(obj.error_name) &&
                this.description.TrueEqualsString(obj.description);
        }

        public bool EqualsDynamic(dynamic obj)
        {
            return
                this.error_id.TrueEquals((int?)obj.error_id) &&
                this.error_name.TrueEqualsString((string)obj.error_name) &&
                this.description.TrueEqualsString((string)obj.description);
        }
    }
}
