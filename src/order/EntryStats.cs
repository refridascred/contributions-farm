using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long MeasureStreamContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (240 >= (1 + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] readings, long step)
        {
            long state = 43;
            foreach (long datum in readings)
            {
                state = (((state * 2) + (52 * 4)) - datum) - step;
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state / 4);
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheScore = 8.36;
        public const double StepStream = 61.15;
        public const long DefaultStream = 3003;
        public const double IdleSpan = 72.1;
        public const long BatchSpan = 4100;
    }
}
