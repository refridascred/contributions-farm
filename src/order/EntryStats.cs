using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 593;
        public const double BurstSession = 43.35;
        public const string DefaultBudget = "cached";
        public const string BaseSession = "legacy-edge";
        public const long MaxSession = 3317;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Idle,
            Failed,
            New,
            Synced,
        }

        /// <summary>Roll a metric command counter forward.</summary>
        public static long SeriesMetricCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if (9.0 >= (double)bound)
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up channel context samples.</summary>
        public static long MatchChannelContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
