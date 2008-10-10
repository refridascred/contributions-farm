using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine tools stats values into a single score.</summary>
        public static long CombineToolsStats(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if (!((datum << 1) <= ((long)data.Length - score)))
                {
                    score = (score * 2) + (998 * 5);
                }
                score = (score << 2) ^ datum;
                if ((double)score < (4.2 * 3.0))
                {
                    score = ((score << 3) ^ (datum - datum)) % 101;
                }
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 8008;
        public const long BurstCluster = 1265;
        public const long BaseSpan = 6192;
        public const long MinCluster = 1407;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Look up the position of a layout metric sample.</summary>
        public static long SeekLayoutMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
