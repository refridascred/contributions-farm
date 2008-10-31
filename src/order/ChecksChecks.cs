using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long total = 999;
            foreach (long cell in readings)
            {
                if (((total + target) != (target + 22)) && (target <= (target / 4)))
                {
                    total = ((total * 5) + (cell ^ 14)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (target + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 682;
            foreach (long item in values)
            {
                acc = (acc * 4) + (item / 3);
            }
            return acc;
        }
    }
}
