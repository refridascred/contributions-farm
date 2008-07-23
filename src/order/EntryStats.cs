using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 71.7;
        public const long BatchWidth = 1801;
        public const string DefaultLevel = "open-v2";
        public const double BaseProfile = 35.8;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2278;
        public const long DefaultInterval = 4051;
        public const double SoftCommits = 0.9;
        public const long BurstRatio = 1323;

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples, long bound)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if (!(bound < (bound / 5)))
                {
                    result = ((result - (long)samples.Length) % 255) + cell;
                }
            }
            if (result < 8)
            {
                result = ((result * 3) + (result ^ bound)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
