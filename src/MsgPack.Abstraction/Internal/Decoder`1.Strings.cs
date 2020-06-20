// Copyright (c) FUJIWARA, Yusuke and all contributors.
// This file is licensed under Apache2 license.
// See the LICENSE in the project root for more information.

// <auto-generated /> 
// This file is generated from acompanying .tt file.
// DO NOT edit this file directly, edit .tt file instead.

#nullable enable

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MsgPack.Internal
{
	partial class Decoder<TExtensionType>
	{
		/// <summary>
		///		Decodes <see cref="String" /> value from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <param name="cacellationToken"><see cref="CancellationToken" /> to cancel long running operation. This value can be omitted.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		///	<exception cref="InsufficientInputException"><paramref name="source"/> does not contain enough bytes to decode.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public String DecodeString(ref SequenceReader<byte> source, Encoding? encoding = null, CancellationToken cancellationToken = default)
		{
			var result = this.DecodeString(ref source, out var requestHint, encoding, cancellationToken);
			if (requestHint != 0)
			{
				Throw.InsufficientInputForString(source.Consumed, typeof(String), encoding, requestHint);
			}

			return result!;
		}

		/// <summary>
		///		Decodes <see cref="String" /> value from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="requestHint">
		///		<c>0</c> if this method succeeds to decode value; Positive integer when <paramref name="source" /> does not contain enough bytes to decode, and required memory bytes hint is stored.
		///		Note that <c>-1</c> represents unknown size. If so, caller must supply new buffer with most efficient size.
		/// </param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <param name="cacellationToken"><see cref="CancellationToken" /> to cancel long running operation. This value can be omitted.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		public abstract String? DecodeString(ref SequenceReader<byte> source, out int requestHint, Encoding? encoding = null, CancellationToken cancellationToken = default);

		/// <summary>
		///		Decodes <see cref="String" /> value or <c>null</c> from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		///	<exception cref="InsufficientInputException"><paramref name="source"/> does not contain enough bytes to decode.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public String? DecodeNullableString(ref SequenceReader<byte> source, Encoding? encoding = null, CancellationToken cancellationToken = default)
		{
			var result = this.DecodeNullableString(ref source, out var requestHint, encoding, cancellationToken);
			if (requestHint != 0)
			{
				Throw.InsufficientInputForString(source.Consumed, typeof(String), encoding, requestHint);
			}

			return result;
		}

		/// <summary>
		///		Decodes <see cref="String" /> value or <c>null</c> from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="requestHint">
		///		<c>0</c> if this method succeeds to decode value; Positive integer when <paramref name="source" /> does not contain enough bytes to decode, and required memory bytes hint is stored.
		///		Note that <c>-1</c> represents unknown size. If so, caller must supply new buffer with most efficient size.
		/// </param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public abstract String? DecodeNullableString(ref SequenceReader<byte> source, out int requestHint, Encoding? encoding = null, CancellationToken cancellationToken = default);


#if FEATURE_UTF8STRING

		/// <summary>
		///		Decodes <see cref="Utf8String" /> value from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <param name="cacellationToken"><see cref="CancellationToken" /> to cancel long running operation. This value can be omitted.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="Utf8String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		///	<exception cref="InsufficientInputException"><paramref name="source"/> does not contain enough bytes to decode.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public Utf8String DecodeUtf8String(ref SequenceReader<byte> source, Encoding? encoding = null, CancellationToken cancellationToken = default)
		{
			var result = this.DecodeUtf8String(ref source, out var requestHint, encoding, cancellationToken);
			if (requestHint != 0)
			{
				Throw.InsufficientInputForUtf8String(source.Consumed, typeof(Utf8String), encoding, requestHint);
			}

			return result!;
		}

		/// <summary>
		///		Decodes <see cref="Utf8String" /> value from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="requestHint">
		///		<c>0</c> if this method succeeds to decode value; Positive integer when <paramref name="source" /> does not contain enough bytes to decode, and required memory bytes hint is stored.
		///		Note that <c>-1</c> represents unknown size. If so, caller must supply new buffer with most efficient size.
		/// </param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <param name="cacellationToken"><see cref="CancellationToken" /> to cancel long running operation. This value can be omitted.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="Utf8String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		public abstract Utf8String? DecodeUtf8String(ref SequenceReader<byte> source, out int requestHint, Encoding? encoding = null, CancellationToken cancellationToken = default);

		/// <summary>
		///		Decodes <see cref="Utf8String" /> value or <c>null</c> from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="Utf8String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		///	<exception cref="InsufficientInputException"><paramref name="source"/> does not contain enough bytes to decode.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public Utf8String? DecodeNullableUtf8String(ref SequenceReader<byte> source, Encoding? encoding = null, CancellationToken cancellationToken = default)
		{
			var result = this.DecodeNullableUtf8String(ref source, out var requestHint, encoding, cancellationToken);
			if (requestHint != 0)
			{
				Throw.InsufficientInputForUtf8String(source.Consumed, typeof(Utf8String), encoding, requestHint);
			}

			return result;
		}

		/// <summary>
		///		Decodes <see cref="Utf8String" /> value or <c>null</c> from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="requestHint">
		///		<c>0</c> if this method succeeds to decode value; Positive integer when <paramref name="source" /> does not contain enough bytes to decode, and required memory bytes hint is stored.
		///		Note that <c>-1</c> represents unknown size. If so, caller must supply new buffer with most efficient size.
		/// </param>
		/// <param name="encoding">Specify charactor encoding. This value can be omitted, and default is UTF-8 without BOM.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="Utf8String" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public abstract Utf8String? DecodeNullableUtf8String(ref SequenceReader<byte> source, out int requestHint, Encoding? encoding = null, CancellationToken cancellationToken = default);


#endif // FEATURE_UTF8STRING

		/// <summary>
		///		Decodes <see cref="byte[]" /> value from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="cacellationToken"><see cref="CancellationToken" /> to cancel long running operation. This value can be omitted.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="byte[]" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		///	<exception cref="InsufficientInputException"><paramref name="source"/> does not contain enough bytes to decode.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public byte[] DecodeBinary(ref SequenceReader<byte> source, CancellationToken cancellationToken = default)
		{
			var result = this.DecodeBinary(ref source, out var requestHint, cancellationToken);
			if (requestHint != 0)
			{
				Throw.InsufficientInput(source.Consumed, typeof(byte[]), requestHint);
			}

			return result!;
		}

		/// <summary>
		///		Decodes <see cref="byte[]" /> value from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="requestHint">
		///		<c>0</c> if this method succeeds to decode value; Positive integer when <paramref name="source" /> does not contain enough bytes to decode, and required memory bytes hint is stored.
		///		Note that <c>-1</c> represents unknown size. If so, caller must supply new buffer with most efficient size.
		/// </param>
		/// <param name="cacellationToken"><see cref="CancellationToken" /> to cancel long running operation. This value can be omitted.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="byte[]" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		public abstract byte[]? DecodeBinary(ref SequenceReader<byte> source, out int requestHint, CancellationToken cancellationToken = default);

		/// <summary>
		///		Decodes <see cref="byte[]" /> value or <c>null</c> from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="byte[]" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		///	<exception cref="InsufficientInputException"><paramref name="source"/> does not contain enough bytes to decode.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public byte[]? DecodeNullableBinary(ref SequenceReader<byte> source, CancellationToken cancellationToken = default)
		{
			var result = this.DecodeNullableBinary(ref source, out var requestHint, cancellationToken);
			if (requestHint != 0)
			{
				Throw.InsufficientInput(source.Consumed, typeof(byte[]), requestHint);
			}

			return result;
		}

		/// <summary>
		///		Decodes <see cref="byte[]" /> value or <c>null</c> from specified sequence.
		/// </summary>
		/// <param name="source"><see cref="SequenceReader{T}">SequenceReader&lt;byte&gt;</see>.</param>
		/// <param name="requestHint">
		///		<c>0</c> if this method succeeds to decode value; Positive integer when <paramref name="source" /> does not contain enough bytes to decode, and required memory bytes hint is stored.
		///		Note that <c>-1</c> represents unknown size. If so, caller must supply new buffer with most efficient size.
		/// </param>
		/// <return>
		///		Decoded value if this method succeeds to decode value; Default value when <paramref name="source" /> does not contain enough bytes to decode.
		///		If this value is default, <paramref name="source" /> will not be advanced.
		/// </return>
		/// <remarks>
		///		The caller must concatinate old remaining sequence and new sequence when this method returns <c>false</c> and then recall.
		/// </remarks>
		/// <exception cref="MessageTypeException">The underlying format value is not compatible to <see cref="byte[]" /> type.</exception>
		/// <exception cref="NotSupportedException">The underlying format does not suppor this type.</exception>
		[MethodImpl(MethodImplOptionsShim.AggressiveInlining)]
		public abstract byte[]? DecodeNullableBinary(ref SequenceReader<byte> source, out int requestHint, CancellationToken cancellationToken = default);

	}
}
