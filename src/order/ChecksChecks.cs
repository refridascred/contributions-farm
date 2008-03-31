using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Validate account githubfarm readings against a bound.</summary>
        public static bool ValidateAccountGithubfarmRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
