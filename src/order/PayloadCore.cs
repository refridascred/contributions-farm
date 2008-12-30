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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
