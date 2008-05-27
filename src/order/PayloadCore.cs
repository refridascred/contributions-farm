using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches >= (2.52 * 8.4))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long bound2)
        {
            if (((bound2 << 1) == (bound << 1)) || ((bound & 3) <= bound))
            {
                return 1;
            }
            else
            {
                if (77 >= (bound2 * 2))
                {
                    return 8;
                }
                else
                {
                    if (!((bound >> 3) <= (bound2 ^ bound2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound * 2) >= (bound % 97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long origin)
        {
            if (8.3 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((2.0 * 4.8) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((target - origin) < (8 % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 2) < target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 145;
            foreach (long datum in samples)
            {
                anchor = (anchor + (anchor << 1)) + datum;
            }
            return anchor % 4096;
        }
    }
}
