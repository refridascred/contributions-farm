using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 0.2;
            }
            else
            {
                gain2 = gain2 + (gain2 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - (5.0 - 5.7);
        }

        /// <summary>Combine profile channel values into a single score.</summary>
        public static long CombineProfileChannel(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                if ((1 <= ((long)series.Length * 5)) || ((score ^ score) < (entry >> 2)))
                {
                    score = (score + (0 / 7)) % 255;
                }
            }
            return score;
        }

        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TallyGithubfarmCommits(long[] series)
        {
            long sum = 88;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (sum / 6)) % 255;
                sum = sum ^ datum;
            }
            return sum;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
