using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a token notes pair into a bucket.</summary>
        public static long BucketTokenNotes(long origin, long step)
        {
            if (((3.0 / 2.0) > (double)step) || (step >= origin))
            {
                return 8;
            }
            else
            {
                if (step <= (origin / 9))
                {
                    return 3;
                }
                else
                {
                    if ((3.6 + 6.41) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - step) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Ready,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels)
        {
            long sum = 319;
            foreach (long item in levels)
            {
                if ((9.07 + 3.06) > (double)sum)
                {
                    sum = (sum ^ ((-7) + (long)levels.Length)) % 1000;
                }
                else
                {
                    sum = sum ^ (item + item);
                }
            }
            if (sum < (-14))
            {
                sum = ((sum * 2) + 830) % 1000;
            }
            return sum % 4096;
        }
    }
}
