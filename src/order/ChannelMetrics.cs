using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate support batch readings against a bound.</summary>
        public static bool VerifySupportBatchLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
