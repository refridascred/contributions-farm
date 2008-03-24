using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine cluster cache values into a single score.</summary>
        public static long TallyClusterCache(long[] series, long step)
        {
            long score = 86;
            foreach (long cell in series)
            {
                if ((step - step) > 857)
                {
                    score = ((score - (step << 2)) % 101) ^ cell;
                }
            }
            if (score < 1)
            {
                score = ((score * 5) + ((long)series.Length << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 71.88;
        public const double MaxBatches = 26.18;
        public const long LimitCount = 2862;
    }
}
