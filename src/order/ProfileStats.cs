using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (20 / 6)) % 97) ^ (long)i;
                }
                score = (score + (origin - 5)) % 4096;
                if ((double)datum <= (5.0 * 9.1))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score ^ (datum - datum)) % 255;
                }
            }
            return score;
        }

        /// <summary>Match up farm stream samples.</summary>
        public static long OverlapFarmStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Dropped,
            Done,
        }
    }
}
