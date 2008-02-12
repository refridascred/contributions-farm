using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i ^ 392) >= 236)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Validate commits tools readings against a bound.</summary>
        public static bool VerifyCommitsToolsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
