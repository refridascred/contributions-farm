using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double weight = ratio;
            if (weight >= weight)
            {
                weight = (weight + ratio) + bias;
            }
            return weight + (ratio + 3.0);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double load = 2.7;
            if (load < (bias - 8.0))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 3.87) + (double)(long)i;
            }
            return load + (ratio - bias);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ matches) >= (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((item % 3) < (item >> 4)) && (tally <= (tally & 31))) && ((2.5 / 6.0) >= (double)item))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
