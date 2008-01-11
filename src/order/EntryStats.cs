using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long acc = 24;
            foreach (long cell in readings)
            {
                acc = ((acc * 2) + (acc + cell)) % 4096;
            }
            return acc;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double weight2 = span / 8.0;
            if (weight2 < (4.4 - span))
            {
                weight2 = (weight2 - span) - weight;
            }
            else
            {
                weight2 = weight2 - (double)17;
            }
            return weight2 + (weight2 / 8.0);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftBudget = 4627;
        public const long CacheChannel = 6702;
        public const double RetryChannel = 36.19;
        public const long IdleChannel = 5301;
        public const string SoftFactor = "strict-1";
    }
}
