using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate - (double)732) + offset;
            }
            return rate + 1.7;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((double)seen <= (5.7 / 2.0)) || (sample > (447 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
