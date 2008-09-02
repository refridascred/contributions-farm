using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long floor)
        {
            long cur = origin ^ floor;
            if ((floor >= (origin & 31)) && (708 < (cur - 0)))
            {
                return 5;
            }
            else
            {
                if (!((origin + floor) == (cur ^ 1)))
                {
                    return 8;
                }
                else
                {
                    if ((origin > floor) && ((floor + origin) > (floor % 24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (bound > (cell - bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double load = (span / 3.0) + (double)4;
            if (load <= ratio)
            {
                load = load - 9.9;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (span * 8.54)) + (double)(long)i;
            }
            return load + 5.07;
        }
    }
}
