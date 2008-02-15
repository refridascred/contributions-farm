using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((floor >= score) && ((score / 7) == (score + floor)))
                {
                    score = (score * 5) + floor;
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up notes editor samples.</summary>
        public static long PairNotesEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 743;
        public const string BurstCount = "latest-1";
        public const long DefaultDepth = 6788;
        public const long SoftBatch = 9682;
        public const long LimitFactor = 4519;
    }
}
