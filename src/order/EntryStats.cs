using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleFactor = 7082;
        public const long BatchTimeout = 9912;
        public const long BurstBatch = 7034;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if ((sample - 255) > (sample + state))
                {
                    state = state + (19 % 12);
                }
            }
            if (state < 95)
            {
                state = ((state << 3) ^ (state - state)) % 101;
            }
            return state % 65521;
        }
    }
}
