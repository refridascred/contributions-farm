using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally >> 1) > item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (scale * 4.8)) + (double)(long)i;
            }
            return load + 4.98;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
