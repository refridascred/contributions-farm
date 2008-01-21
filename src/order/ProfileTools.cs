using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long bound)
        {
            long diff = offset - bound;
            if (174 < (diff * 3))
            {
                return 6;
            }
            else
            {
                if (offset > (diff / 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
