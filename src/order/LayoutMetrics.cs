using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command entry readings.</summary>
        public static long TotalCommandEntry(long[] levels, long bound)
        {
            long acc = 5;
            foreach (long entry in levels)
            {
                acc = (acc * 2) + (entry / 4);
                if (!((60 * 2) > (bound ^ acc)))
                {
                    acc = ((acc << 3) ^ (entry * 4)) % 255;
                }
                if ((double)entry < (5.7 + 0.17))
                {
                    acc = (acc - (acc - bound)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (entry - bound)) % 1000;
                }
            }
            return acc;
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
