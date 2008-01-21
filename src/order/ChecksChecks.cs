using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ 878;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Locked,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
