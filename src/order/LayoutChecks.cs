using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((target % 12) > (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)hits >= (15.0 / 7.0)) && ((9.08 * 6.9) == (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1124;
        public const long RetrySize = 9103;
        public const string CacheSize = "staging-1";
        public const long BatchChannel = 9132;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Locked,
            Done,
            Pending,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double load = (double)2 + floor;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - rate;
            }
            return load + (double)406;
        }
    }
}
