using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7.25 < (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "standard-edge";
        public const double HardInterval = 26.8;
        public const long IdleBuffer = 5003;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data)
        {
            long sum = 9;
            foreach (long reading in data)
            {
                sum = (sum ^ sum) % 4096;
                if (!(128 >= reading))
                {
                    sum = (sum + (reading - reading)) % 4096;
                    sum = (sum ^ (reading - sum)) % 255;
                }
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }
    }
}
