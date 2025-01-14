// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The Enum12. </summary>
    public readonly partial struct Enum12 : IEquatable<Enum12>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum12"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum12(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string AllValue = "All";

        /// <summary> Windows. </summary>
        public static Enum12 Windows { get; } = new Enum12(WindowsValue);
        /// <summary> Linux. </summary>
        public static Enum12 Linux { get; } = new Enum12(LinuxValue);
        /// <summary> All. </summary>
        public static Enum12 All { get; } = new Enum12(AllValue);
        /// <summary> Determines if two <see cref="Enum12"/> values are the same. </summary>
        public static bool operator ==(Enum12 left, Enum12 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum12"/> values are not the same. </summary>
        public static bool operator !=(Enum12 left, Enum12 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum12"/>. </summary>
        public static implicit operator Enum12(string value) => new Enum12(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum12 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum12 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
