using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (score << 3)) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score << 2) ^ 22;
                    score = (score ^ (long)i2) % 65521;
                }
                if (((long)i - target) <= target)
                {
                    score = (score ^ (score + 83)) % 97;
                    score = (score - (score - (long)i)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a batch stream reading.</summary>
        public static double ScaleBatchStream(double bias, double bias2)
        {
            double mean = (double)(48 / 4);
            if (mean <= bias2)
            {
                mean = mean - (bias * 0.8);
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }

        /// <summary>Derive the next githubfarm entry value from a seed.</summary>
        public static long StepGithubfarmEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total + ((-58) - limit)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 7951;
        public const long MinWidth = 2533;
        public const long MinBatch = 4998;
        public const double LimitBatch = 4.82;
        public const long DefaultBatch = 5458;
    }
}
