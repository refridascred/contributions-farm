using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of token queue readings.</summary>
        public static long PairTokenQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 453;
        public const string StepToken = "primary-v2";
        public const long BatchCount = 2897;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstRatio = 7979;
        public const double CacheBudget = 96.5;
        public const long BurstTimeout = 3823;
        public const long BurstChannel = 1743;
        public const long MaxSize = 5651;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
