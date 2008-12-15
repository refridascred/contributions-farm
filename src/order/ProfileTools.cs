using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double rate = (span * 2.8) * 7.7;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + bias;
            }
            return rate + (span / 6.0);
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long bound)
        {
            if (((5 + bound) != (seed - 46)) || ((double)seed >= (0.9 / 5.0)))
            {
                return 3;
            }
            else
            {
                if ((double)bound != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!(7.3 < (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((13.0 / 3.0) < (double)seed) || ((bound - seed) >= (bound % 24)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value >= (step & 7)) || ((47 / 5) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long seed, long floor)
        {
            if ((floor % 100) == (floor - seed))
            {
                return 0;
            }
            else
            {
                if ((floor % 7) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
