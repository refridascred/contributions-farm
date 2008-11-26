using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate metric queue readings against a bound.</summary>
        public static bool GuardMetricQueueLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long step = bound + origin;
            if (((origin % 16) == (origin + origin)) && ((bound % 2) <= bound))
            {
                return 7;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (!(6 < (step + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (bound ^ origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
