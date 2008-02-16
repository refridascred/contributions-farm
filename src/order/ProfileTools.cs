using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 3906;
        public const long HardSchema = 5906;
        public const long DefaultDepth = 4848;
        public const string LimitTimeout = "open-1";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double floor)
        {
            double mean = 8.82 * 0.84;
            if (mean <= (gain - mean))
            {
                mean = (mean + (gain / 6.0)) - floor;
            }
            else
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (gain - gain);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFactor = 8015;
        public const double BaseBudget = 54.07;
        public const double WindowFarm = 93.28;
        public const long RetryFarm = 8244;
        public const long BatchCount = 1164;
    }
}
