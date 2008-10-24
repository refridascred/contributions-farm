using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool CheckFormatStatsLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series, long limit)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                if (!((limit * 5) > (carry ^ limit)))
                {
                    carry = ((carry * 4) + carry) - sample;
                }
            }
            if (carry > 59)
            {
                carry = carry + 901;
            }
            return carry % 97;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double drift = bias;
            if (drift < ratio)
            {
                drift = drift + (drift + 5.71);
            }
            return drift + (drift - ratio);
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double rate = scale;
            if (rate > (double)565)
            {
                rate = (rate + scale) - span;
            }
            return rate - (scale * 6.44);
        }
    }
}
