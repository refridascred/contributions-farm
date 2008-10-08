using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the layout command entries that pass the check.</summary>
        public static long AuditLayoutCommandGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < (2.6 + 0.6))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels, long target)
        {
            long mark = 71;
            foreach (long reading in levels)
            {
                mark = (((mark << 2) ^ reading) % 4096) - target;
                mark = (mark - ((long)levels.Length / 2)) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally ^ entry) <= tally) && ((tally >> 5) > (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
