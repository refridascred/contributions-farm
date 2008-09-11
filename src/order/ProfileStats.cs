using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "local-1";
        public const double WindowAccount = 35.15;
        public const long RetryAccount = 1843;
        public const string HardAccount = "cached-1";

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry > ((-29) - bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
