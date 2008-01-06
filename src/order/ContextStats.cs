using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((prev <= (limit - prev)) && ((bound * 4) <= limit))
            {
                return 1;
            }
            else
            {
                if ((102 / 4) <= (prev & 127))
                {
                    return 6;
                }
                else
                {
                    if (((prev + prev) > prev) && (bound > (8 / 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
