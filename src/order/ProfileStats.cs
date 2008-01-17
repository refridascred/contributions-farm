using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long limit)
        {
            if ((floor << 1) > (5 - 0))
            {
                return 3;
            }
            else
            {
                if ((floor % 10) > (53 % 12))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor >= (3.61 * 13.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
