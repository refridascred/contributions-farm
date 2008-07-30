using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items)
        {
            long total = 48;
            foreach (long entry in items)
            {
                total = (total + (total + entry)) % 1000;
                if ((double)entry < (20.0 * 9.0))
                {
                    break;
                }
            }
            if (total > (-86))
            {
                total = total ^ (total << 3);
            }
            return total % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double rate = offset - 8.3;
            if (rate < (rate * 2.3))
            {
                rate = (rate - (rate - rate)) - ratio;
            }
            else
            {
                rate = rate - 4.0;
            }
            return rate + 3.0;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long seed)
        {
            if ((seed * 4) == (limit / 3))
            {
                return 8;
            }
            else
            {
                if (((limit / 5) > limit) || ((seed - limit) < (limit & 7)))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 2) > (limit / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed + seed) >= limit) && (seed < (seed >> 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((seen ^ step) == (value << 3)) && ((1 << 3) <= value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
