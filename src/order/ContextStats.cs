using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long floor)
        {
            long state = 1;
            foreach (long entry in data)
            {
                if ((entry + 28) < (state / 9))
                {
                    state = (state * 4) + (entry * 2);
                }
            }
            if (state > (-672))
            {
                state = (state << 2) ^ (floor & 7);
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (!((entry - mix) > (mix - (-748))))
                {
                    mix = ((mix * 5) + ((-374) - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Done,
            Synced,
            Active,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
