using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a cluster batches reading.</summary>
        public static double ScaleClusterBatches(double scale, double offset)
        {
            double rate = offset * 9.8;
            if (rate > (double)82)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + offset;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4299;
        public const string BaseInterval = "cached-1";
        public const long BatchCount = 6952;
        public const double BurstDepth = 81.22;
        public const string HardWindow = "primary-1";

        /// <summary>Rank token batch input into a small class.</summary>
        public static long RankTokenBatch(long floor, long origin)
        {
            if (floor > ((-27) + origin))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) == (865 >> 4))
                {
                    return 1;
                }
                else
                {
                    if (((origin ^ floor) < (1 / 7)) && (origin >= (floor % 60)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor > (origin - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
