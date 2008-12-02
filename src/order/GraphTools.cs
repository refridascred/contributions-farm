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

        /// <summary>Audit metrics account readings against a rule.</summary>
        public static long TallyMetricsAccountGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)517 != (double)seen)
                {
                    seen = ((seen + 2) ^ value) + offset;
                }
            }
            return seen;
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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Closed,
            Ready,
            New,
            Locked,
        }
    }
}
