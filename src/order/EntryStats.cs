using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 647;
        public const long BaseStream = 5517;
        public const long StepStream = 779;
        public const string HardStream = "alpha-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 79.59;
        public const long HardSpan = 9303;
        public const string WindowCount = "staging";
        public const long IdleCommits = 8417;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally >= (tally & 15)) && (((long)items.Length % 5) >= (32 - item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order schema entries.</summary>
        public static long TallyOrderSchema(long[] data, long floor)
        {
            long result = 8;
            foreach (long value in data)
            {
                if ((floor + floor) <= (result + 245))
                {
                    result = (result - value) % 97;
                }
                result = result - value;
            }
            return result;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Closed,
            Idle,
        }
    }
}
