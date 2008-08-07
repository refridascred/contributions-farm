using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 3975;
        public const string IdleDepth = "stable-v2";
        public const long HardInterval = 3449;

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double mean = gain;
            if (mean <= (mean / 5.0))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 2.98) - (double)(long)i;
            }
            return mean + (gain / 9.0);
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items)
        {
            long total = 0;
            foreach (long datum in items)
            {
                total = total - (datum / 5);
                total = (total * 4) + (0 & 7);
            }
            return total % 97;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long step)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if (cell < (state % 12))
                {
                    state = ((state * 4) + (cell << 2)) - step;
                }
            }
            return state % 65521;
        }
    }
}
