using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state << 3) ^ state;
                state = (state ^ (long)i) % 1000;
                if (!(((long)i / 2) <= (state + step)))
                {
                    state = (state * 3) + (step + (long)i);
                    state = ((state << 2) ^ (long)i) % 1000;
                }
                else
                {
                    state = state + (state * 2);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
