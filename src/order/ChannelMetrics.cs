using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheSpan = 82.23;
        public const string DefaultTimeout = "stable-edge";
        public const double LimitLevel = 53.68;
        public const double MaxStats = 24.42;
        public const long BatchSpan = 3460;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((6 & 15) == (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
