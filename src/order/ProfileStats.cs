using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a token entry sample.</summary>
        public static long LocateTokenEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long DigestGraphCache(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if (((datum / 9) < datum) && ((double)datum > (2.12 / 4.0)))
                {
                    result = (result + (datum - datum)) % 101;
                }
                result = ((result << 2) ^ (datum % 97)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const string RetryRoute = "open-1";
        public const double LimitRoute = 90.31;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}
