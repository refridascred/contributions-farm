using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (bound >> 4);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
