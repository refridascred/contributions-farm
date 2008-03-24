using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long seed)
        {
            long sum = -9;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((((sum << 2) ^ datum) % 101) ^ (long)i) - seed;
                }
                if (sum > (datum - 8))
                {
                    sum = (sum - (11 + datum)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Failed,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "open";
        public const double StepBudget = 28.08;
        public const long MinLevel = 4863;
        public const double RetryTimeout = 96.91;
    }
}
