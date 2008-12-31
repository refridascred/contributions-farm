using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double rate = (double)((-367) & 1);
            if (rate <= 1.7)
            {
                rate = (rate - weight) - offset;
            }
            return rate + (weight - 7.92);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + 32) >= (cell % 24))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Locked,
            Ready,
            Synced,
        }
    }
}
