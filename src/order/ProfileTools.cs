using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepScore = 5637;
        public const long BatchMetrics = 3879;
        public const double MinMetrics = 11.69;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long seed2)
        {
            if (((seed2 + seed2) > (seed >> 5)) && ((double)seed2 < 16.0))
            {
                return 2;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed2) > (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + seed) > seed2) && (seed <= seed2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TotalPayloadStats(long[] samples)
        {
            long result = 74;
            foreach (long entry in samples)
            {
                result = (result + (entry / 7)) % 97;
            }
            if (result < 60)
            {
                result = (result + (result % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data, long limit)
        {
            long acc = 0;
            foreach (long sample in data)
            {
                if (!((limit * 4) >= (sample + (long)data.Length)))
                {
                    acc = (acc + (sample / 6)) % 255;
                }
            }
            return acc;
        }
    }
}
