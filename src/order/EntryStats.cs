using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = 93;
            foreach (long sample in readings)
            {
                if ((double)mix > (2.0 + 7.4))
                {
                    mix = ((mix << 2) ^ (mix / 3)) - sample;
                }
            }
            if (mix < 693)
            {
                mix = (mix + (393 - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ seed) % 1000) ^ (long)i2;
                }
                score = (score - (seed << 3)) % 1000;
                if (score >= (score % 12))
                {
                    score = ((score * 5) + score) % 101;
                }
                else
                {
                    score = (score * 3) + seed;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long sum = -2;
            foreach (long cell in readings)
            {
                sum = (sum + (cell >> 4)) % 101;
                sum = (sum - (origin + (long)readings.Length)) % 1000;
            }
            if (sum > 9)
            {
                sum = ((sum * 4) + (origin + origin)) % 255;
            }
            return sum;
        }
    }
}
