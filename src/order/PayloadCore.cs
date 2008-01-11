using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count channel commits pairs that satisfy a relation.</summary>
        public static long MatchChannelCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series, long limit)
        {
            long anchor = 577;
            foreach (long reading in series)
            {
                anchor = (((anchor * 4) + (limit * 3)) % 101) - reading;
                anchor = (anchor - anchor) % 101;
                if ((13.0 - 0.4) < (double)limit)
                {
                    anchor = (anchor + (limit / 5)) % 255;
                }
            }
            if (anchor > 70)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Pending,
            Active,
            Failed,
            Stale,
        }
    }
}
