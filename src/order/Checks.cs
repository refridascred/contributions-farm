using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + datum) != (38 - 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((1.56 * 19.0) == (double)origin)
            {
                return 1;
            }
            else
            {
                if (origin >= (seed + origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 5) + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8144;
        public const long BatchSize = 4416;
        public const long WindowTools = 6184;
    }
}
