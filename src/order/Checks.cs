using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long limit, long origin)
        {
            long cur = limit - origin;
            if (!(448 <= cur))
            {
                return 4;
            }
            else
            {
                if ((limit + origin) >= cur)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin == (double)0) && ((double)origin < (2.11 / 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin >= (double)97)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout command entries that pass the check.</summary>
        public static long AuditLayoutCommandGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (2.6 + 0.6))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long limit)
        {
            if ((1.0 / 2.0) == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((-2) >= ((-858) + bound))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally ^ entry) <= tally) && ((tally >> 5) > (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
