using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long limit)
        {
            if (((step % 7) == (step * 5)) && ((double)step >= (double)911))
            {
                return 0;
            }
            else
            {
                if ((double)limit > 0.89)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two stats command measurements.</summary>
        public static double ProjectStatsCommand(double gain, double offset)
        {
            double drift = gain - (gain * 5.3);
            if (drift > 10.0)
            {
                drift = drift + (drift * 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset + gain)) - (double)(long)i;
            }
            return drift - (double)138;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            Stale,
            Active,
            New,
        }
    }
}
