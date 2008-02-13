using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Active,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxScore = 3511;
        public const long MaxGraph = 9540;
        public const double LimitBudget = 56.57;
        public const double BatchSize = 28.5;

        /// <summary>Count profile already pairs that satisfy a relation.</summary>
        public static long MatchProfileAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every order window entry stays within the limit.</summary>
        public static bool CheckOrderWindowBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
