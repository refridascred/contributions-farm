using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long mark = 876;
            foreach (long datum in levels)
            {
                mark = ((mark << 2) ^ (mark >> 2)) % 97;
                mark = mark + datum;
                if (3 < (mark << 3))
                {
                    mark = ((mark * 2) + (7 << 1)) % 101;
                }
            }
            if (mark < 580)
            {
                mark = (mark + (mark / 7)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double mean = (bias / 2.0) + bias;
            if (mean <= mean)
            {
                mean = (mean - 0.63) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (bias - 3.7)) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
