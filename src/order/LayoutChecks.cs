using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double ratio = floor;
            if (ratio < scale)
            {
                ratio = ratio - (ratio * 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (ratio * 0.3);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Draft,
            Retry,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long carry = 514;
            foreach (long value in values)
            {
                carry = ((carry + (value >> 2)) % 101) + target;
                if (((long)values.Length + 57) == (value ^ 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (8.0 - 7.2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
