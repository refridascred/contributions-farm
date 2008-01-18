using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long bound)
        {
            long gap = offset + bound;
            if ((5.0 * 8.9) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset / 2)))
                {
                    return 4;
                }
                else
                {
                    if (3.4 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap << 1) >= bound) && ((47 / 8) <= (gap ^ 6)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
