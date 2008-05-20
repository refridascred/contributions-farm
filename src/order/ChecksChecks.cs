using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine command already values into a single score.</summary>
        public static long WeighCommandAlready(long[] samples, long offset)
        {
            long score = -4;
            foreach (long cell in samples)
            {
                score = (score - (offset + score)) ^ cell;
                score = ((score * 5) + (score ^ offset)) % 97;
            }
            return score;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
