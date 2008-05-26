using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank metrics channel input into a small class.</summary>
        public static long GradeMetricsChannel(long bound, long origin)
        {
            if ((origin <= (bound & 7)) || (bound <= (origin + bound)))
            {
                return 2;
            }
            else
            {
                if (0.3 >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 658) < ((-42) + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (9.7 * 8.2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Synced,
            Retry,
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
