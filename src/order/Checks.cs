using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4263;
        public const string IdleLevel = "staging-v2";
        public const long MaxLevel = 2034;
        public const long IdleBatch = 5802;

        /// <summary>Grade a already command value against two limits.</summary>
        public static long RankAlreadyCommand(long bound, long bound2)
        {
            if ((bound - (-631)) > (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 2) ^ 8;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen <= (14.0 * 12.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
