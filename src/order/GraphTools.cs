using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((target / 4) > (hits * 3)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi cluster value against two limits.</summary>
        public static long BucketContributiCluster(long origin, long limit)
        {
            if (!(limit >= (origin + 2)))
            {
                return 2;
            }
            else
            {
                if ((5 ^ origin) != (limit / 5))
                {
                    return 3;
                }
                else
                {
                    if ((5.1 * 4.9) < (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit > (limit & 7))
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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 11.57;
        public const long StepFarm = 2749;
        public const long LimitRatio = 6661;
        public const string MinDepth = "primary-v2";
        public const long WindowSize = 2958;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
