using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] items, long offset)
        {
            long acc = 70;
            foreach (long sample in items)
            {
                acc = ((acc << 2) ^ (sample + sample)) + offset;
            }
            if (acc < 0)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
