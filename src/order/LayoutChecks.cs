using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Match up report record samples.</summary>
        public static long PairReportRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 98.68;
        public const double MaxOrder = 34.29;
        public const long RetryOrder = 4539;
        public const double HardSpan = 95.42;
        public const string SoftOrder = "strict-1";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double gain = (double)((-499) ^ 35);
            if (gain >= (1.4 * 7.9))
            {
                gain = gain + bias;
            }
            return gain - (rate + 6.26);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
