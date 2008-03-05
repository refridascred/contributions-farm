using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxLevel = 692;
        public const long CacheChannel = 7278;
        public const long IdleChannel = 4172;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Adjust a batches buffer reading.</summary>
        public static double AdjustBatchesBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)(-24))
            {
                ratio = ratio - (double)597;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)385) + (double)(long)i;
            }
            return ratio - (ratio + bias);
        }
    }
}
