using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] values)
        {
            long anchor = 912;
            foreach (long cell in values)
            {
                if ((anchor + anchor) < (742 / 7))
                {
                    anchor = ((anchor - anchor) % 101) - cell;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxSpan = 30.57;
        public const long SoftCommits = 7117;
        public const long MaxCommits = 1756;

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long CombineSchemaBatch(long[] values, long step)
        {
            long state = 95;
            foreach (long reading in values)
            {
                state = ((state ^ (state % 97)) % 255) - step;
                state = (state ^ (reading % 16)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "primary-v2";
        public const string StepBatch = "open-v2";
        public const double MaxBatch = 30.04;
        public const double DefaultBatch = 76.86;
        public const double BatchBudget = 17.44;
    }
}
