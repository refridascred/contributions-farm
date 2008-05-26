using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long target)
        {
            long next = limit - target;
            if ((8.8 * 19.0) == (double)limit)
            {
                return 2;
            }
            else
            {
                if (next < (limit + next))
                {
                    return 4;
                }
                else
                {
                    if ((limit + next) >= (target ^ next))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 3) >= (target >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((644 % 60) != (403 ^ step))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
