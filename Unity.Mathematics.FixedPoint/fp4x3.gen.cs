//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct fp4x3 : System.IEquatable<fp4x3>, IFormattable
    {
        public fp4 c0;
        public fp4 c1;
        public fp4 c2;

        /// <summary>fp4x3 zero value.</summary>
        public static readonly fp4x3 zero;

        /// <summary>Constructs a fp4x3 matrix from three fp4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(fp4 c0, fp4 c1, fp4 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a fp4x3 matrix from 12 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(fp m00, fp m01, fp m02,
                     fp m10, fp m11, fp m12,
                     fp m20, fp m21, fp m22,
                     fp m30, fp m31, fp m32)
        { 
            this.c0 = new fp4(m00, m10, m20, m30);
            this.c1 = new fp4(m01, m11, m21, m31);
            this.c2 = new fp4(m02, m12, m22, m32);
        }

        /// <summary>Constructs a fp4x3 matrix from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(fp v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a fp4x3 matrix from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(int v)
        {
            this.c0 = (fp4)v;
            this.c1 = (fp4)v;
            this.c2 = (fp4)v;
        }

        /// <summary>Constructs a fp4x3 matrix from a int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(int4x3 v)
        {
            this.c0 = (fp4)v.c0;
            this.c1 = (fp4)v.c1;
            this.c2 = (fp4)v.c2;
        }

        /// <summary>Constructs a fp4x3 matrix from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(uint v)
        {
            this.c0 = (fp4)v;
            this.c1 = (fp4)v;
            this.c2 = (fp4)v;
        }

        /// <summary>Constructs a fp4x3 matrix from a uint4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp4x3(uint4x3 v)
        {
            this.c0 = (fp4)v.c0;
            this.c1 = (fp4)v.c1;
            this.c2 = (fp4)v.c2;
        }


        /// <summary>Implicitly converts a single fp value to a fp4x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator fp4x3(fp v) { return new fp4x3(v); }

        /// <summary>Explicitly converts a single int value to a fp4x3 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp4x3(int v) { return new fp4x3(v); }

        /// <summary>Explicitly converts a int4x3 matrix to a fp4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp4x3(int4x3 v) { return new fp4x3(v); }

        /// <summary>Explicitly converts a single uint value to a fp4x3 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp4x3(uint v) { return new fp4x3(v); }

        /// <summary>Explicitly converts a uint4x3 matrix to a fp4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp4x3(uint4x3 v) { return new fp4x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator * (fp4x3 lhs, fp4x3 rhs) { return new fp4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator * (fp4x3 lhs, fp rhs) { return new fp4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator * (fp lhs, fp4x3 rhs) { return new fp4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator + (fp4x3 lhs, fp4x3 rhs) { return new fp4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator + (fp4x3 lhs, fp rhs) { return new fp4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator + (fp lhs, fp4x3 rhs) { return new fp4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator - (fp4x3 lhs, fp4x3 rhs) { return new fp4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator - (fp4x3 lhs, fp rhs) { return new fp4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator - (fp lhs, fp4x3 rhs) { return new fp4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator / (fp4x3 lhs, fp4x3 rhs) { return new fp4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator / (fp4x3 lhs, fp rhs) { return new fp4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator / (fp lhs, fp4x3 rhs) { return new fp4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator % (fp4x3 lhs, fp4x3 rhs) { return new fp4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator % (fp4x3 lhs, fp rhs) { return new fp4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator % (fp lhs, fp4x3 rhs) { return new fp4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise increment operation on a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator ++ (fp4x3 val) { return new fp4x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator -- (fp4x3 val) { return new fp4x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (fp4x3 lhs, fp4x3 rhs) { return new bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (fp4x3 lhs, fp rhs) { return new bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (fp lhs, fp4x3 rhs) { return new bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (fp4x3 lhs, fp4x3 rhs) { return new bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (fp4x3 lhs, fp rhs) { return new bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (fp lhs, fp4x3 rhs) { return new bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (fp4x3 lhs, fp4x3 rhs) { return new bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (fp4x3 lhs, fp rhs) { return new bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (fp lhs, fp4x3 rhs) { return new bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (fp4x3 lhs, fp4x3 rhs) { return new bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (fp4x3 lhs, fp rhs) { return new bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (fp lhs, fp4x3 rhs) { return new bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator - (fp4x3 val) { return new fp4x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 operator + (fp4x3 val) { return new fp4x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise equality operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (fp4x3 lhs, fp4x3 rhs) { return new bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (fp4x3 lhs, fp rhs) { return new bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (fp lhs, fp4x3 rhs) { return new bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two fp4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (fp4x3 lhs, fp4x3 rhs) { return new bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp4x3 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (fp4x3 lhs, fp rhs) { return new bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp value and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (fp lhs, fp4x3 rhs) { return new bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }



        /// <summary>Returns the fp4 element at a specified index.</summary>
        unsafe public ref fp4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (fp4x3* array = &this) { return ref ((fp4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the fp4x3 is equal to a given fp4x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(fp4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the fp4x3 is equal to a given fp4x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((fp4x3)o); }


        /// <summary>Returns a hash code for the fp4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the fp4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("fp4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        /// <summary>Returns a string representation of the fp4x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("fp4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a fp4x3 matrix constructed from three fp4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(fp4 c0, fp4 c1, fp4 c2) { return new fp4x3(c0, c1, c2); }

        /// <summary>Returns a fp4x3 matrix constructed from from 12 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(fp m00, fp m01, fp m02,
                                  fp m10, fp m11, fp m12,
                                  fp m20, fp m21, fp m22,
                                  fp m30, fp m31, fp m32)
        {
            return new fp4x3(m00, m01, m02,
                             m10, m11, m12,
                             m20, m21, m22,
                             m30, m31, m32);
        }

        /// <summary>Returns a fp4x3 matrix constructed from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(fp v) { return new fp4x3(v); }

        /// <summary>Returns a fp4x3 matrix constructed from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(int v) { return new fp4x3(v); }

        /// <summary>Return a fp4x3 matrix constructed from a int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(int4x3 v) { return new fp4x3(v); }

        /// <summary>Returns a fp4x3 matrix constructed from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(uint v) { return new fp4x3(v); }

        /// <summary>Return a fp4x3 matrix constructed from a uint4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 fp4x3(uint4x3 v) { return new fp4x3(v); }

        /// <summary>Return the fp3x4 transpose of a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 transpose(fp4x3 v)
        {
            return fp3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a fp4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(fp4x3 v)
        {
            return csum(asuint(v.c0) * uint4(0x841D8225u, 0xC9393C7Du, 0xD42EAFA3u, 0xD9AFD06Du) + 
                        asuint(v.c1) * uint4(0x97A65421u, 0x7809205Fu, 0x9C9F0823u, 0x5A9CA13Bu) + 
                        asuint(v.c2) * uint4(0xAFCDD5EFu, 0xA88D187Du, 0xCF6EBA1Du, 0x9D88E5A1u)) + 0xEADF0775u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a fp4x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(fp4x3 v)
        {
            return (asuint(v.c0) * uint4(0x747A9D7Bu, 0x4111F799u, 0xB5F05AF1u, 0xFD80290Bu) + 
                    asuint(v.c1) * uint4(0x8B65ADB7u, 0xDFF4F563u, 0x7069770Du, 0xD1224537u) + 
                    asuint(v.c2) * uint4(0xE99ED6F3u, 0x48125549u, 0xEEE2123Bu, 0xE3AD9FE5u)) + 0xCE1CF8BFu;
        }

    }
}
