using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a support tools pair into a bucket.</summary>
        public static long RankSupportTools(long floor, long floor2)
        {
            if ((7.85 + 3.1) >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor - floor) < (floor & 31))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor2 & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate session report samples.</summary>
        public static long CombineSessionReport(long[] samples, long bound)
        {
            long acc = 884;
            foreach (long item in samples)
            {
                if (((8.7 + 1.8) >= (double)bound) || ((item & 63) == (acc << 1)))
                {
                    acc = ((acc * 5) + (item - acc)) % 255;
                }
            }
            if (acc > (-26))
            {
                acc = (acc + 0) % 101;
            }
            return acc;
        }
    }
}
