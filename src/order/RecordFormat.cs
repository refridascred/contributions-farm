using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)bound > (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Rank checks report input into a small class.</summary>
        public static long ClassifyChecksReport(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (diff >= (diff / 6))
            {
                return 1;
            }
            else
            {
                if (diff < (0 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!(((-56) / 8) < (seed2 >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (4.5 * 9.54))
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

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (floor - gain))
            {
                mean = mean - 9.5;
            }
            else
            {
                mean = mean - (double)230;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)4) - (double)(long)i;
            }
            return mean + 7.32;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
