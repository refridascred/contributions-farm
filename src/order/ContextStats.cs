using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((12.0 / 5.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long limit)
        {
            long gap = seed ^ limit;
            if ((double)limit != (7.7 - 17.0))
            {
                return 6;
            }
            else
            {
                if (limit < (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((gap - seed) < (seed % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)gap < 18.0)
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
