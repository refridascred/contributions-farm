using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metric already samples.</summary>
        public static long CompareMetricAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
