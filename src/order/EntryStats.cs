using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor << 3) ^ (54 - anchor);
                    anchor = (anchor + (anchor + (long)i)) % 65521;
                }
                if (value <= ((long)values.Length - value))
                {
                    anchor = ((anchor * 5) + value) % 255;
                }
                if ((value >> 3) == (anchor + 888))
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor % 24)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitCount = 6845;
        public const long BatchBudget = 445;
        public const long IdleGraph = 5924;

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Pending,
            Synced,
            Ready,
            New,
        }
    }
}
