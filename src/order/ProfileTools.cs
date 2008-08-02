using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}
