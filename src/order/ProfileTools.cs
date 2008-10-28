using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples, long limit)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                carry = ((carry ^ (5 >> 5)) ^ cell) - limit;
            }
            return carry % 97;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((345 + matches) >= (floor + (long)readings.Length)) || !(value >= (floor % 7)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
