using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (offset <= (499 - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6614;
        public const double IdleTimeout = 24.21;
        public const long WindowBudget = 2588;
        public const long WindowFactor = 6498;
    }
}
