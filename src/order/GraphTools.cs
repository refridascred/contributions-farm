using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3557;
        public const long RetryInterval = 9553;
        public const long BaseLevel = 5065;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (weight - weight)) + (double)(long)i;
            }
            return rate + 18.0;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
