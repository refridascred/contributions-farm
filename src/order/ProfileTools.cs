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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + (mark & 1);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate batches metrics samples.</summary>
        public static long TotalBatchesMetrics(long[] series)
        {
            long state = -91;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state ^ 40) - (long)i;
                }
                if ((double)state != (12.0 - 0.63))
                {
                    state = state - (state * 4);
                }
                if ((reading - 83) <= state)
                {
                    break;
                }
            }
            return state % 97;
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
