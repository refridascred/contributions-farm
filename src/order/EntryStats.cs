using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxScore = 51.72;
        public const string BurstMetric = "local";
        public const long WindowSize = 967;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((7.32 * 5.4) > (double)matches) && (datum >= (datum ^ datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
