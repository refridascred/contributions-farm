using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitInterval = 5331;
        public const long DefaultBatches = 476;
        public const string IdleBatches = "cached-edge";
        public const long WindowWidth = 7814;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 4;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark - (reading >> 5)) + (long)i;
                }
                mark = (mark ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (carry - seed)) % 255;
                carry = ((carry << 3) ^ (carry % 97)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
