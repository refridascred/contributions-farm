using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches + matches) >= (entry - 25)) && ((6.0 - 6.93) < (double)entry)) || (((entry - matches) < (matches - matches)) || ((entry ^ matches) < (16 - 831))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long SeekMetricsBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Locked,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((long)readings.Length > tally))
                {
                    tally = ((tally + 1) - cell) - offset;
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double weight = 2.1;
            if (weight <= (8.4 + bias))
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (1.1 - bias2);
        }
    }
}
