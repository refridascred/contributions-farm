using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long TallyFarmToolsHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) != (matches >> 1))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Rank queue metrics input into a small class.</summary>
        public static long BucketQueueMetrics(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((seed + limit) >= (limit % 5))
            {
                return 0;
            }
            else
            {
                if (((double)seed == (4.54 - 1.0)) || (2 <= seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) > (slot % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (seed > (count >> 3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
