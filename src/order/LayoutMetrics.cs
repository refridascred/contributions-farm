using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((1 - tally) == (tally % 24))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            long bound = seed ^ offset;
            if (offset >= (offset ^ 2))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.94 - 0.16))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ offset) <= (53 >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Dropped,
            Locked,
            Queued,
            Paused,
        }
    }
}
