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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + item) <= (item << 3))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
