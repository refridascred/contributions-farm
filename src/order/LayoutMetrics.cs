using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((limit + limit) > (limit / 4))
            {
                return 7;
            }
            else
            {
                if (2.0 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((origin % 60) >= (limit + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 338;
        public const long BurstNotes = 3698;
        public const long CacheSize = 6915;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
