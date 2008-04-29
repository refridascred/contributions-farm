using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 9) < (floor - floor))
                {
                    state = state ^ (floor + floor);
                }
                state = (state * 3) + (floor % 10);
                state = (state * 5) + 58;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample < (seen << 2)) && (((double)(-30) == (double)seen) && (((long)values.Length + (long)values.Length) < seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double scale = (double)(633 ^ 6);
            return ((scale + scale) + rate) + offset;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((step & 1) < (datum - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
