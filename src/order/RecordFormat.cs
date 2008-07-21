using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a window session reading by value.</summary>
        public static long FindWindowSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long RollBatchesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a account profile pair into a bucket.</summary>
        public static long BucketAccountProfile(long target, long seed)
        {
            if ((target ^ seed) == (seed - 8))
            {
                return 5;
            }
            else
            {
                if ((386 % 12) > seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed + seed) > (seed - 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((sum << 2) <= sum)
                {
                    sum = sum + ((long)i + (long)i);
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
