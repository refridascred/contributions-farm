using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long offset)
        {
            if (seed >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (((-227) > seed) && (3.0 <= (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 15) > (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
