using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long limit)
        {
            if (!((double)limit != (8.5 / 3.0)))
            {
                return 6;
            }
            else
            {
                if (8 <= (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if (origin < 55)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((6.1 * 2.0) >= (double)hits)
                {
                    hits = ((hits + 1) - datum) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((double)seen >= (16.0 - 1.11)) || ((4.6 * 8.6) > (double)floor)) && (reading <= 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
