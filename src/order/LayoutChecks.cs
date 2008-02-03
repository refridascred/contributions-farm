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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (count / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (offset > (offset % 2))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
