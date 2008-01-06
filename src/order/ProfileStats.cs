using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate stats buffer readings against a bound.</summary>
        public static bool VerifyStatsBufferBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i - floor) >= (floor - (long)i))
                {
                    break;
                }
                carry = carry - (floor / 8);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
