using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
