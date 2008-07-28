using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheLevel = 42.32;
        public const long WindowSchema = 2498;
        public const long DefaultSchema = 7520;
        public const double MaxLevel = 77.64;
        public const string IdleWidth = "staging-v2";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((cell * 5) <= (tally % 2)) && ((tally + tally) >= tally)) && (tally > (cell + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
