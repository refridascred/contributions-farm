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

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
