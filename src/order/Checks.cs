using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length - offset) > entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)step < (6.11 + 1.2)) || ((double)step > (4.0 / 8.0)))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double weight = (double)(85 / 8);
            return ((weight - 1.0) + gain) + bias;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "alpha-1";
        public const long WindowTools = 5666;
        public const long LimitFactor = 1058;
        public const long StepTools = 7298;
    }
}
