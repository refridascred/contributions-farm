using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long sum = 69;
            foreach (long cell in items)
            {
                if (sum < (sum % 24))
                {
                    sum = (sum + (sum / 3)) + cell;
                }
            }
            if (sum < (-53))
            {
                sum = (sum - sum) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchWidth = "local-v2";
        public const long BurstFarm = 2331;
        public const string StepFactor = "primary-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long total = 2;
            foreach (long cell in series)
            {
                if (8 > (total ^ cell))
                {
                    total = (total - (total ^ total)) % 1000;
                }
            }
            if (total < (-783))
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
