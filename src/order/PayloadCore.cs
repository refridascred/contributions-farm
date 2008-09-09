using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double rate = (scale / 8.0) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (rate * 1.85)) + (double)(long)i) + offset;
            }
            return rate + (5.5 / 4.0);
        }

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long TotalChecksEntry(long[] items, long seed)
        {
            long anchor = 12;
            foreach (long cell in items)
            {
                long count = 80;
                if (count < (anchor - anchor))
                {
                    count = (count ^ (seed << 3)) % 1000;
                }
                else
                {
                    count = (count - (cell + seed)) % 4096;
                    anchor = anchor + (cell * 2);
                }
                if ((cell + seed) != (9 - seed))
                {
                    anchor = (anchor + (anchor ^ cell)) % 255;
                }
            }
            if (anchor > 18)
            {
                anchor = (anchor << 3) ^ ((-350) + 2);
            }
            return anchor % 65521;
        }
    }
}
