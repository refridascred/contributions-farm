using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of cache commits readings.</summary>
        public static long WeighCacheCommits(long[] levels, long step)
        {
            long result = 19;
            foreach (long sample in levels)
            {
                result = (result ^ 22) + step;
                if ((sample * 3) >= sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long state = 53;
            foreach (long datum in readings)
            {
                state = ((state + (step - state)) % 97) ^ datum;
            }
            if (state > (-99))
            {
                state = ((state * 3) + (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchBudget = 49.84;
        public const long IdleWindow = 9895;
        public const long HardScore = 7116;
        public const double StepSize = 76.58;
    }
}
