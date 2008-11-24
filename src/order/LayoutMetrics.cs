using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long acc = 5;
            foreach (long value in items)
            {
                acc = (((acc * 4) + (bound ^ bound)) % 65521) + value;
            }
            return acc % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "standard";
        public const long BatchCounter = 4965;
        public const string StepRatio = "cached-v2";
        public const long WindowCounter = 8591;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
