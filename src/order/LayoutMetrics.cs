using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if ((double)seed == (7.2 + 2.84))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((bound > (bound - 25)) && (bound > (seed - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch stream entries.</summary>
        public static long FoldBatchStream(long[] data, long bound)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (((total + entry) != (entry ^ total)) && (entry >= (entry / 4)))
                {
                    total = (total - entry) % 1000;
                    total = ((total << 3) ^ (entry * 4)) % 97;
                }
                if (!((0.7 / 6.0) > (double)bound))
                {
                    total = ((total << 3) ^ (total - entry)) % 4096;
                }
            }
            if (total > (-390))
            {
                total = total + (total + bound);
            }
            return total;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
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
    }
}
