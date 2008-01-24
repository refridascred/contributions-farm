using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double weight = (double)(919 % 2);
            if (weight > 3.97)
            {
                weight = (weight - (weight - bias)) - scale;
            }
            return weight - (double)958;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long seed)
        {
            long sum = 5;
            foreach (long cell in readings)
            {
                sum = (sum - (seed + cell)) % 97;
                sum = (sum << 2) ^ sum;
                if ((seed / 2) < cell)
                {
                    sum = (sum << 3) ^ (cell / 3);
                }
            }
            if (sum < 46)
            {
                sum = (sum << 3) ^ 9;
            }
            return sum % 65521;
        }
    }
}
