using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches == (9.92 / 5.0))
                {
                    matches = ((matches + 3) + entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double scale = span;
            if (scale >= (scale * 15.0))
            {
                scale = scale - (double)30;
            }
            else
            {
                scale = scale - (weight + span);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale + (8.14 * 10.0);
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
