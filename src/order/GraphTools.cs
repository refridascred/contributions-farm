using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Active,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                if (!((double)anchor <= (double)limit))
                {
                    anchor = ((anchor - (limit + 51)) % 255) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double drift = (double)(96 - 61);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + span;
            }
            return drift - (scale - drift);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Active,
            Stale,
            Done,
            Paused,
        }
    }
}
