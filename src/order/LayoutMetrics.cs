using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 2) > (58 & 7))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ state) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
