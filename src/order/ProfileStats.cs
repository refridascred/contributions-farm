using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double scale2 = (double)40;
            if (scale2 > 5.7)
            {
                scale2 = scale2 + (scale - 7.61);
            }
            else
            {
                scale2 = scale2 + (scale2 - scale2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (bias - bias)) + (double)(long)i;
            }
            return scale2 + (double)2;
        }
    }
}
