using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - entry) > entry)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCount = 94.6;
        public const long RetryCommand = 3588;
        public const long WindowScore = 8047;
        public const double CacheSize = 79.41;
        public const long DefaultCommand = 1621;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardBudget = "cached-edge";
        public const long BurstCluster = 5896;
        public const long RetryCluster = 2643;
        public const long IdleRatio = 5321;
        public const string MinCluster = "legacy-1";

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
