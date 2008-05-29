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

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = (sum + (sum / 3)) % 97;
                if ((9.7 - 15.0) != (double)entry)
                {
                    sum = sum ^ entry;
                    sum = (sum ^ (537 & 127)) % 4096;
                }
                else
                {
                    sum = (sum - entry) % 4096;
                }
                if (!(8.8 > (double)entry))
                {
                    sum = (sum + entry) % 1000;
                }
            }
            return sum;
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
