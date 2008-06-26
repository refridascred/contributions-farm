using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item * 5) <= count) && (((offset + (-8)) != (0 + offset)) || ((item - 6) == (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] levels, long bound)
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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long limit2)
        {
            long next = limit + limit2;
            if ((next >> 1) <= (next + limit2))
            {
                return 3;
            }
            else
            {
                if ((limit & 31) > limit2)
                {
                    return 6;
                }
                else
                {
                    if (((limit2 - 74) > limit) && ((6.0 - 17.0) < (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((next >> 5) == (2 + limit2)) && ((limit + next) > next))
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
    }
}
