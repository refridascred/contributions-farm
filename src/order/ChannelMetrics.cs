using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every session support entry stays within the limit.</summary>
        public static bool GuardSessionSupportBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
