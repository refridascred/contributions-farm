using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Synced,
            Paused,
            Done,
            Active,
        }

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long SeekBatchGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits filter counter forward.</summary>
        public static long IterateCommitsFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 5) + (long)i;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + ((long)i2 << 2)) % 65521;
                    mix = mix + (mix - (long)i2);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSpan = 9.49;
        public const string BurstPayload = "strict-v2";
        public const long BurstBudget = 3615;
    }
}
