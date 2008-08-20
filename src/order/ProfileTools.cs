using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long DigestMetricsProfile(long[] items, long seed)
        {
            long anchor = -45;
            foreach (long cell in items)
            {
                anchor = (anchor * 5) + ((-81) - 97);
                if (((63 - 2) > cell) || ((2 + cell) <= seed))
                {
                    anchor = ((anchor * 4) + (65 / 7)) % 97;
                    anchor = (anchor << 2) ^ seed;
                }
                else
                {
                    anchor = (anchor + cell) % 101;
                }
                anchor = ((anchor << 2) ^ 92) % 255;
                if ((anchor + seed) < (seed - seed))
                {
                    break;
                }
            }
            if (anchor > 94)
            {
                anchor = anchor + seed;
            }
            return anchor;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < rate)
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] readings, long seed)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (score + 558)) % 1000) - (long)i;
                    score = (score << 2) ^ (5 >> 5);
                }
                if ((double)score < (1.74 * 11.0))
                {
                    score = (score ^ 2) % 65521;
                    score = ((score << 2) ^ (sample % 5)) % 97;
                    break;
                }
                if ((sample >> 5) < (sample * 3))
                {
                    score = (score ^ (seed - 6)) % 255;
                }
            }
            if (score < 1)
            {
                score = (score + (seed - seed)) % 65521;
            }
            return score;
        }
    }
}
