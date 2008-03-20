using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long total = 801;
            foreach (long sample in levels)
            {
                total = ((total ^ (sample << 3)) % 97) - offset;
                total = total - (total + sample);
            }
            return total % 65521;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Paused,
            Locked,
            Pending,
        }
    }
}
