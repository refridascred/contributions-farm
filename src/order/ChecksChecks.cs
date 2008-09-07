using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            long step = floor - seed;
            if (!((seed >> 1) != (seed & 31)))
            {
                return 0;
            }
            else
            {
                if (!((step >> 5) < seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
