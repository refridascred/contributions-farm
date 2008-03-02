using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double load = bias2;
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + (-4)) < reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Validate command farm readings against a bound.</summary>
        public static bool GuardCommandFarmRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
