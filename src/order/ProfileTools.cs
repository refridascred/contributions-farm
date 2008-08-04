using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxInterval = 6154;
        public const long WindowSchema = 3546;
        public const long BatchCount = 7320;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long SeriesNotesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ (target * 3);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
