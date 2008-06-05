using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheInterval = 2423;
        public const string MinQueue = "staging-1";
        public const long StepQueue = 2683;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long step)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                if (!((step - entry) >= 99))
                {
                    result = result - ((long)readings.Length >> 1);
                }
                if (step > (step - step))
                {
                    result = (result * 2) + (19 & 1);
                }
                if ((step - step) < (entry / 5))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 5) + step;
            }
            return result % 4096;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (limit << 3)) % 97;
                if ((long)i <= limit)
                {
                    state = (state * 3) + ((long)i + state);
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 1000;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading / 2) >= (reading * 4))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
