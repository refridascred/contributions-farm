using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen > (seen * 2))
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long PairBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long floor)
        {
            if ((floor * 5) != (seed + 717))
            {
                return 2;
            }
            else
            {
                if ((floor % 64) != (seed * 2))
                {
                    return 1;
                }
                else
                {
                    if ((seed + floor) == (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((81 - seed) >= (floor + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
