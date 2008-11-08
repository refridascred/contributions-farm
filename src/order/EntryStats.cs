using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 2) != (item - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long bound, long origin)
        {
            if (((bound >> 3) < (bound & 63)) || ((5.7 + 9.91) <= (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) <= bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double drift = (double)9;
            if (drift <= 4.1)
            {
                drift = drift + 0.4;
            }
            else
            {
                drift = drift + (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
