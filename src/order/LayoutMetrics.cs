using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long origin)
        {
            if ((target * 2) < (337 / 8))
            {
                return 3;
            }
            else
            {
                if (!(origin <= (target << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (10.0 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
