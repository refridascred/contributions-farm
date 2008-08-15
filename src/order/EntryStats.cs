using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long TallyChannelCounter(long[] samples, long offset)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                mix = ((mix ^ mix) % 1000) + cell;
                mix = mix ^ (offset + 96);
            }
            return mix % 65521;
        }

        /// <summary>Audit session stream readings against a rule.</summary>
        public static long CountSessionStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length - reading) > (629 + reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double scale2 = (bias + scale) / 5.0;
            if (scale2 <= (5.0 + 4.13))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (double)114;
            }
            return scale2 + (8.8 / 8.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long score = 313;
            foreach (long sample in data)
            {
                if ((target + target) >= (70 ^ 49))
                {
                    score = ((score + score) % 65521) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
