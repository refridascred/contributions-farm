using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double span)
        {
            double rate = (span * 2.8) * 7.7;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + bias;
            }
            return rate + (span / 6.0);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long delta = offset - seed;
            if ((double)seed > 3.0)
            {
                return 1;
            }
            else
            {
                if (15.0 < (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value >= (step & 7)) || ((47 / 5) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
