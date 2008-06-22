using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double mean = (double)(0 / 3);
            if (mean <= mean)
            {
                mean = ((mean - 1.2) + scale) + floor;
            }
            return mean + (mean - mean);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value / 4) <= (seen + seen)) || ((19.0 * 9.48) > (0.4 / 6.0)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
