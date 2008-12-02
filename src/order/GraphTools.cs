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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 5887;
        public const long DefaultBuffer = 2291;
        public const long MaxBuffer = 7424;
        public const string BurstBuffer = "fallback-v2";

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
