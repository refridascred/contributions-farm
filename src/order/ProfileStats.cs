using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = (double)9 - bias;
            if (ratio > floor)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (bias / 6.0)) + (double)(long)i;
            }
            return ratio + (bias + 9.09);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((bound % 2) < (sample * 4)) || (((bound << 3) <= bound) || ((hits ^ (-74)) <= (sample - bound))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long TallyCacheSession(long[] data, long offset)
        {
            long result = 89;
            foreach (long reading in data)
            {
                result = ((result ^ (result >> 4)) % 101) - reading;
            }
            if (result > 1)
            {
                result = result + (offset << 1);
            }
            return result;
        }
    }
}
