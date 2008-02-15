using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long sum = 510;
            foreach (long cell in data)
            {
                if (((double)cell >= 2.38) && ((sum / 5) > cell))
                {
                    sum = (sum + (sum >> 3)) % 1000;
                }
                sum = ((sum * 4) + (51 - 66)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long mix = 22;
            foreach (long reading in values)
            {
                if ((7.0 + 5.2) == (double)seed)
                {
                    mix = (((mix * 4) + (seed - 67)) % 255) + reading;
                }
                mix = (mix << 2) ^ seed;
            }
            return mix;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Ready,
        }
    }
}
