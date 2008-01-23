using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 4638;
        public const long StepRoute = 9884;
        public const double BaseBudget = 28.78;
        public const long BurstRoute = 5290;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Draft,
            Active,
            Failed,
        }
    }
}
