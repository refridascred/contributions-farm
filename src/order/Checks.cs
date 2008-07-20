using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
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
