using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum < (datum % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double rate = (double)((-79) ^ 337);
            if (rate < span)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            New,
            Queued,
            Closed,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
