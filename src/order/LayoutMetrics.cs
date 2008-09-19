using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a editor graph sample.</summary>
        public static long LocateEditorGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long seed)
        {
            long slot = floor - seed;
            if (slot > (3 + slot))
            {
                return 3;
            }
            else
            {
                if ((2.0 * 2.39) <= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 5) < (floor ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((51 - seed) < floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
