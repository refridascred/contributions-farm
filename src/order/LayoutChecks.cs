using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((4.0 / 8.0) != (double)count) && (4 <= (reading >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 - 2.4) < (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
