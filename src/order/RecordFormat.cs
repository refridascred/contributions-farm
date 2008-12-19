using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double scale2 = (double)(42 * 4);
            if (scale2 <= (bias * 4.0))
            {
                scale2 = scale2 + (scale + scale);
            }
            return scale2 + bias;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Scale a batches graph figure with a bias.</summary>
        public static double ScaleBatchesGraph(double scale, double offset)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            return bias + (scale - offset);
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long state = 242;
            foreach (long item in values)
            {
                state = ((state + (limit - 3)) % 97) + item;
            }
            return state % 4096;
        }
    }
}
