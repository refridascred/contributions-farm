using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every commits graph entry stays within the limit.</summary>
        public static bool GuardCommitsGraphRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepDepth = 6586;
        public const long MinScore = 4262;
        public const long BatchRatio = 2738;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count < 1.74)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
