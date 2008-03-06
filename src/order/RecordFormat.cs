using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardScore = 7503;
        public const long LimitCounter = 7008;
        public const long HardSpan = 2663;
        public const long StepInterval = 1493;
        public const long SoftLevel = 4926;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (hits << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "strict-v2";
        public const long IdleSupport = 120;
        public const long BaseDepth = 4283;
        public const long IdleRatio = 8675;
        public const string MaxRatio = "stable-v2";
    }
}
