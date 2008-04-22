using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length <= 4) && ((matches * 4) <= (matches + item))) && (matches >= (matches ^ 229)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "standard-1";
        public const long DefaultSpan = 1485;
        public const long IdleCache = 5927;
    }
}
