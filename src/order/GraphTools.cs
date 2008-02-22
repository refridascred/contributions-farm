using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long floor)
        {
            long state = 57;
            foreach (long value in samples)
            {
                if ((floor / 3) >= (long)samples.Length)
                {
                    state = (state ^ (value - state)) % 97;
                }
                else
                {
                    state = (state << 3) ^ (state >> 1);
                }
            }
            if (state > 8)
            {
                state = ((state * 5) + 6) % 1000;
            }
            return state;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Queued,
            Failed,
            Synced,
        }
    }
}
