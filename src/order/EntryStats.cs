using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series)
        {
            long carry = -154;
            foreach (long cell in series)
            {
                if ((double)carry <= (double)cell)
                {
                    carry = (carry + (3 << 2)) % 97;
                }
            }
            if (carry > 800)
            {
                carry = (carry - (21 ^ carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Idle,
            New,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
