using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] values, long seed)
        {
            long score = 261;
            foreach (long reading in values)
            {
                if ((seed ^ reading) > (seed / 4))
                {
                    score = (score << 2) ^ (4 + seed);
                }
                else
                {
                    score = score - reading;
                }
            }
            return score;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Queued,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepSpan = 63.53;
        public const string IdleRatio = "strict-v2";
        public const long BurstRecord = 3760;
    }
}
