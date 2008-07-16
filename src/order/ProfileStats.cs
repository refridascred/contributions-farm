using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count already metric pairs that satisfy a relation.</summary>
        public static long CompareAlreadyMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor + rate)) + (double)(long)i;
            }
            return drift - (double)841;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((16.0 * 1.0) <= (double)limit) || ((double)519 == (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
