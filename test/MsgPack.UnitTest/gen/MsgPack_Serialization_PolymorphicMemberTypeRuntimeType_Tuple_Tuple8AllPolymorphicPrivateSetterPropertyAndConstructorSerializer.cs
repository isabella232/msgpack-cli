﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor> this_PackValueOfTuple8AllPolymorphicPackValueOfTuple8AllPolymorphicDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>> _packOperationTable;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor_set_Tuple8AllPolymorphic0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>> this_SetUnpackedValueOfTuple8AllPolymorphicSetUnpackedValueOfTuple8AllPolymorphicDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int> this_UnpackValueOfTuple8AllPolymorphicUnpackValueOfTuple8AllPolymorphicDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[8];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[6] = tupleItemSchema6;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema7 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema7 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[7] = tupleItemSchema7;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>>(schema0);
            this._methodBasePolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor_set_Tuple8AllPolymorphic0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor).GetMethod("set_Tuple8AllPolymorphic", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>(this.PackValueOfTuple8AllPolymorphic);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>>(1);
            packOperationTable["Tuple8AllPolymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>(this.PackValueOfTuple8AllPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfTuple8AllPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>>(1);
            unpackOperationTable["Tuple8AllPolymorphic"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfTuple8AllPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple8AllPolymorphic"};
            this.this_PackValueOfTuple8AllPolymorphicPackValueOfTuple8AllPolymorphicDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>(this.PackValueOfTuple8AllPolymorphic);
            this.this_SetUnpackedValueOfTuple8AllPolymorphicSetUnpackedValueOfTuple8AllPolymorphicDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>>(this.SetUnpackedValueOfTuple8AllPolymorphic);
            this.this_UnpackValueOfTuple8AllPolymorphicUnpackValueOfTuple8AllPolymorphicDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfTuple8AllPolymorphic);
        }
        
        private void PackValueOfTuple8AllPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple8AllPolymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private void SetUnpackedValueOfTuple8AllPolymorphic(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor unpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>> unpackedValue) {
            this._methodBasePolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor_set_Tuple8AllPolymorphic0.Invoke(unpackingContext, new object[] {
                        unpackedValue});
        }
        
        private void UnpackValueOfTuple8AllPolymorphic(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>), "Tuple8AllPolymorphic", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTuple8AllPolymorphicSetUnpackedValueOfTuple8AllPolymorphicDelegate);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicPrivateSetterPropertyAndConstructor>(), this._unpackOperationTable);
            }
        }
    }
}