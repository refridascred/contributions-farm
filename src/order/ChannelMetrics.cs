using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every checks editor entry stays within the limit.</summary>
        public static bool ValidateChecksEditorLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long RankBatchesCommits(long bound, long offset)
        {
            long edge = bound + offset;
            if (((double)edge != (double)(-27)) && ((offset - 4) == (offset + 519)))
            {
                return 7;
            }
            else
            {
                if (((double)offset != (double)4) || ((645 - edge) != (17 + edge)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
