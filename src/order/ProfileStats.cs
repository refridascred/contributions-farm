using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "primary-1";
        public const long WindowTimeout = 1288;
        public const string BaseInterval = "staging-edge";
        public const long HardScore = 1306;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 2) ^ (step * 2)) - (long)i2;
                    score = (score - (13 * 2)) % 1000;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = (((score * 2) + (step - 57)) % 255) ^ (long)i3;
                }
                for (int i4 = 0; i4 < 8; i4++)
                {
                    score = (score + (step << 3)) - (long)i4;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6.6 + 3.1) >= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
