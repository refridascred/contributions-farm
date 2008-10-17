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

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFactor = 77.68;
        public const double RetryFilter = 60.09;
        public const long DefaultInterval = 1680;

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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum < (9 >> 2)) && ((((long)data.Length - bound) == (tally - tally)) && ((double)tally <= (0.4 - 16.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
