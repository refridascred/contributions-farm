using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double drift = (double)598 + (floor * 8.0);
            if (drift <= (floor / 7.0))
            {
                drift = (drift - (floor * 1.85)) - weight;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (4.6 - drift);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of checks editor readings.</summary>
        public static long OverlapChecksEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches > 8) || (matches <= (matches / 8))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((49 / 3) <= (count & 3)) && (((long)series.Length - value) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
