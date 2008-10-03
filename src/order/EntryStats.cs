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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
