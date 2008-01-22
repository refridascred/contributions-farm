using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (floor > (83 + floor))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long MeasureSessionLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum + matches) < 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
