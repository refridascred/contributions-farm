using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCount = "open-edge";
        public const double BatchCache = 50.57;
        public const long SoftBudget = 1200;
        public const long BaseRatio = 1840;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstWidth = 75.74;
        public const long HardWidth = 4710;
        public const long WindowReport = 9737;
        public const long DefaultReport = 4207;
        public const long IdleReport = 4709;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Ready,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - ((long)i - step);
                sum = sum - step;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
