using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long target2)
        {
            long delta = target + target2;
            if ((1.0 >= (double)target2) && ((-5) >= (delta + 61)))
            {
                return 4;
            }
            else
            {
                if ((double)delta >= (2.6 * 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)target == (8.27 * 13.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 1) == (62 - 264))
                {
                    tally = ((tally + 1) - reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long target2)
        {
            long slot = target + target2;
            if (!((target + target2) > (target * 2)))
            {
                return 2;
            }
            else
            {
                if (((938 ^ target2) != (target2 & 31)) || ((target2 * 4) == (target - target)))
                {
                    return 0;
                }
                else
                {
                    if ((target / 6) != (slot + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
