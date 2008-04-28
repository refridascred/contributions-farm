using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the entry metrics entries that pass the check.</summary>
        public static long AuditEntryMetricsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)(-838) != (double)target)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Active,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long target, long limit)
        {
            if ((limit / 7) <= (limit * 3))
            {
                return 0;
            }
            else
            {
                if ((target * 4) < (960 * 2))
                {
                    return 2;
                }
                else
                {
                    if ((94 + limit) <= (target & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 3) >= (target + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
