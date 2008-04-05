using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((double)hits < (5.33 + 9.91)) && (((-79) % 7) >= value)) && ((hits - hits) >= (hits - 759)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double scale = (double)((-48) ^ 75);
            if (scale < gain)
            {
                scale = scale + span;
            }
            else
            {
                scale = scale - (scale + gain);
            }
            return scale + scale;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
