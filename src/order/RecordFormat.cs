using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = -100;
            foreach (long sample in items)
            {
                carry = (carry + (773 ^ sample)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long bound)
        {
            if ((4 + seed) >= (6 << 2))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed >> 4))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Stale,
            Done,
        }
    }
}
