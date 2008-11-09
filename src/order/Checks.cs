using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count account commits pairs that satisfy a relation.</summary>
        public static long OverlapAccountCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((8.27 < (double)acc) || (((-26) >> 4) > (step >> 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double rate = 3.0;
            if (rate < (double)990)
            {
                rate = (rate + (bias * 0.6)) - gain;
            }
            else
            {
                rate = rate + 17.0;
            }
            return rate + bias;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((2.8 * 8.13) > (double)tally)
                {
                    tally = ((tally + 1) + entry) - target;
                }
            }
            return tally;
        }
    }
}
