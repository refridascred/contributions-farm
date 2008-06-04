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

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long acc = 509;
            foreach (long entry in values)
            {
                if ((entry - acc) != (acc - entry))
                {
                    acc = ((acc * 3) + (acc % 3)) % 101;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 65521;
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
