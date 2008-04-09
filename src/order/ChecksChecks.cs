using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long origin2)
        {
            long lane = origin ^ origin2;
            if ((origin2 - origin2) >= (lane & 127))
            {
                return 1;
            }
            else
            {
                if (lane > (origin + lane))
                {
                    return 6;
                }
                else
                {
                    if ((9.69 * 13.0) == (double)lane)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            New,
            Failed,
            Done,
        }
    }
}
