using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((seed - seed) == (hits - (long)readings.Length))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample + tally) > (52 << 3)) || ((double)tally <= (9.4 - 14.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long seed)
        {
            long sum = 280;
            foreach (long value in data)
            {
                sum = ((sum + (238 + seed)) % 255) + value;
            }
            return sum;
        }

        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool CheckAccountReportBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 30.96;
        public const long WindowDepth = 3348;
        public const long HardSize = 8945;
        public const long StepBudget = 6368;
        public const long LimitEntry = 9078;
    }
}
