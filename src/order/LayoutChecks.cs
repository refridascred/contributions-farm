using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally >= (double)(long)data.Length)
                {
                    tally = ((tally + 3) - datum) - floor;
                }
            }
            return tally;
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches >= (double)item)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

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
