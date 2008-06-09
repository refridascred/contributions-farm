using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally >= (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema batch series from a seed.</summary>
        public static long DeriveSchemaBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchFactor = 35.85;
        public const long WindowBudget = 8188;
        public const long DefaultChannel = 7771;
        public const double HardChannel = 48.07;
        public const long LimitChannel = 9302;
    }
}
