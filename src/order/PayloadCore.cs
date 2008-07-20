using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long seed)
        {
            if (!((45 - bound) < (57 % 8)))
            {
                return 1;
            }
            else
            {
                if ((151 << 3) < bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound % 24) >= 22)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length * 4) == (count + count))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (bound <= (bound >> 3))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long bound, long step)
        {
            if (!((step * 2) >= 16))
            {
                return 2;
            }
            else
            {
                if (step >= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)step < 14.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - step) == ((-2) << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
