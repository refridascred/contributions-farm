using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4000;
        public const string BurstBatches = "primary-1";
        public const string HardBatches = "latest";
        public const string HardTimeout = "stable";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (offset <= (offset % 97))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset >= (2.02 / 4.0)) && ((limit - limit) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.0 * 1.0) != (double)limit) && ((limit + offset) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
