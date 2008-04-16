using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples)
        {
            long score = 17;
            foreach (long item in samples)
            {
                if ((score + item) <= score)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                score = (score ^ ((long)samples.Length * 5)) % 97;
                if ((8.5 + 7.97) <= (double)item)
                {
                    score = (score * 4) + (item + score);
                }
            }
            return score % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchWidth = "stable-1";
        public const long LimitInterval = 2265;
        public const long MinScore = 3786;
        public const string MinReport = "strict-edge";
        public const long LimitReport = 5086;

        /// <summary>Project the next stats cluster value.</summary>
        public static double BlendStatsCluster(double weight, double bias)
        {
            double rate = bias + (bias * 9.12);
            if (rate >= (double)101)
            {
                rate = (rate - (5.55 + bias)) - weight;
            }
            else
            {
                rate = rate - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
