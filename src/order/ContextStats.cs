using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)49 < (double)acc)
                {
                    acc = (acc ^ (long)i) % 97;
                    acc = (acc << 3) ^ ((-79) + acc);
                    break;
                }
                acc = ((acc * 3) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)floor <= (9.6 - 13.0))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
