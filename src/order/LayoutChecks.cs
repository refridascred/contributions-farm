using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Failed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinScore = 1830;
        public const long MaxCommits = 8632;
        public const long HardBudget = 5148;
        public const string StepCommits = "stable-edge";
        public const double BurstDepth = 95.06;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)(long)levels.Length <= (2.86 / 7.0))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
