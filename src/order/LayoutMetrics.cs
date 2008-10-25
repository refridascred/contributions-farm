using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) > (reading % 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
