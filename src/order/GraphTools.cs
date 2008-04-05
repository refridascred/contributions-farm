using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - value) < ((long)data.Length * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a command profile value against two limits.</summary>
        public static long SortCommandProfile(long seed, long offset)
        {
            if (((seed - seed) >= offset) && ((seed + 492) < seed))
            {
                return 4;
            }
            else
            {
                if (!((seed & 127) > offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset != (1.35 - 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long bound = seed ^ step;
            if (step <= 9)
            {
                return 5;
            }
            else
            {
                if ((bound - seed) >= (seed + step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long CountBufferFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen << 1) == (6 / 9)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
