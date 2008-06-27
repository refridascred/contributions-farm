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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long offset2)
        {
            if ((offset2 <= (offset % 100)) && (offset >= (offset2 + 526)))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 5) > offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset - offset) < (65 >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset2 < 43)
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
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Locked,
            Pending,
            Retry,
        }
    }
}
