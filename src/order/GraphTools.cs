using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 6;
            foreach (long reading in items)
            {
                if (6 < (reading << 3))
                {
                    result = (result ^ (result & 127)) % 4096;
                }
            }
            if (result > 612)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 10.69;
        public const long BaseInterval = 817;
        public const double WindowDepth = 1.83;
        public const long MinSize = 6943;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 6529;
        public const long RetrySpan = 7144;
        public const long HardWidth = 2689;
    }
}
