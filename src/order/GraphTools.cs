using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ step) >= (hits / 9))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
