// Copyright (c) FUJIWARA, Yusuke and all contributors.
// This file is licensed under Apache2 license.
// See the LICENSE in the project root for more information.

// <auto-generated /> 
// This file is generated from acompanying .tt file.
// DO NOT edit this file directly, edit .tt file instead.

#nullable enable

using System;
using System.Buffers;
using System.Text;
using System.Threading;
using MsgPack.Internal;

namespace MsgPack.Serialization
{
	public sealed partial class AsyncDeserializationOperationContext
	{
		public FormatDecoder Decoder { get; }
		public DeserializationOptions Options { get; }
		public Encoding? StringEncoding => this.Options.StringEncoding;
		public ArrayPool<byte> ByteBufferPool => this.Options.ByteBufferPool;
		public int CurrentDepth { get; private set; }
		public CancellationToken CancellationToken { get; }

		public AsyncDeserializationOperationContext(FormatDecoder decoder, DeserializationOptions? options, CancellationToken cancellationToken)
		{
			this.Decoder = Ensure.NotNull(decoder);
			this.Options = options ?? DeserializationOptions.Default;
			this.CurrentDepth = 0;
			this.CancellationToken = cancellationToken;
		}

		public DeserializationOperationContext AsDeserializationOperationContext()
			=> new DeserializationOperationContext(this.Decoder, this.Options, this.CancellationToken);

		public CollectionContext CollectionContext => new CollectionContext(Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, this.CurrentDepth);

		public int IncrementDepth()
		{
			if (this.CurrentDepth == this.Options.MaxDepth)
			{
				Throw.DepthExeeded(this.CurrentDepth, this.Options.MaxDepth);
			}

			return this.CurrentDepth++;
		}

		public int DecrementDepth()
		{
			if (this.CurrentDepth == 0)
			{
				Throw.DepthUnderflow();
			}

			return this.CurrentDepth--;
		}

		public void ValidatePropertyKeyLength(long position, int length)
		{
			if(length > this.Options.MaxPropertyKeyLength)
			{
				Throw.TooLargePropertyKey(position, length, this.Options.MaxPropertyKeyLength);
			}
		}
	}
}