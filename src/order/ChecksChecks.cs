using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally >> 1) > (sample / 6)) || (((long)readings.Length << 2) < sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardBudget = 8970;
        public const double StepAlready = 78.51;
        public const long SoftAlready = 7520;
        public const long BatchAlready = 4035;

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
