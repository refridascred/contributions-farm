using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 4165;
        public const string CacheSpan = "staging-edge";
        public const long CacheGithubfarm = 7303;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowTimeout = "alpha";
        public const long LimitNotes = 9700;
        public const long BaseNotes = 3434;
        public const long HardNotes = 555;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((842 & 63) > state)
                {
                    state = ((state << 3) ^ (floor % 97)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
