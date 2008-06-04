using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleScore = 5299;
        public const long MaxSession = 2849;
        public const string DefaultSession = "cached-v2";

        /// <summary>Roll a order channel counter forward.</summary>
        public static long DeriveOrderChannel(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ (long)i) % 65521;
                if (!(((-44) + total) > total))
                {
                    total = (total + (total - total)) % 101;
                    total = (total - (438 ^ seed)) % 1000;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
