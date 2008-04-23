using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TotalEntryEditor(long[] series)
        {
            long sum = 16;
            foreach (long entry in series)
            {
                if (((entry - entry) <= (entry >> 2)) || (sum <= (sum + 60)))
                {
                    sum = sum ^ (entry * 3);
                }
                else
                {
                    sum = ((sum * 4) + 9) % 255;
                }
            }
            return sum % 4096;
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

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "standard-1";
        public const long DefaultSpan = 1485;
        public const long IdleCache = 5927;
    }
}
