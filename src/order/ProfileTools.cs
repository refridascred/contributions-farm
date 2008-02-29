using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double scale = bias * 18.0;
            if (scale > scale)
            {
                scale = scale + 0.6;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (rate / 8.0)) + (double)(long)i;
            }
            return scale - (double)400;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)target > (2.47 - 5.9))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long seed)
        {
            long state = 55;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ (seed - state)) % 4096;
                if ((double)seed <= 7.2)
                {
                    state = (state << 3) ^ (reading + 2);
                }
                else
                {
                    state = state ^ (seed << 1);
                }
            }
            return state;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
