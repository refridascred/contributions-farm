using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double ratio = bias * 16.0;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio - bias;
            }
            return ratio + (span + span);
        }

        /// <summary>Digest a series of batch cache entries.</summary>
        public static long DigestBatchCache(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                if (sample <= mix)
                {
                    mix = mix - sample;
                }
                else
                {
                    mix = (mix + (sample - mix)) % 4096;
                }
            }
            if (mix > 27)
            {
                mix = (mix << 2) ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Rank filter batches input into a small class.</summary>
        public static long GradeFilterBatches(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((double)edge > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((edge % 12) != (edge - origin))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
