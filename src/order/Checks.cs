using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "staging-v2";
        public const long WindowGithubfarm = 8836;
        public const long SoftRatio = 3396;

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double weight = bias;
            if (weight > (bias * 4.48))
            {
                weight = weight - floor;
            }
            return weight + (bias * 7.6);
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
