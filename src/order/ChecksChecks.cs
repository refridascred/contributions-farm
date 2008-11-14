using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples, long bound)
        {
            long mix = 575;
            foreach (long cell in samples)
            {
                if ((0.64 + 7.2) >= (double)bound)
                {
                    mix = ((mix * 2) + (0 & 255)) + cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
