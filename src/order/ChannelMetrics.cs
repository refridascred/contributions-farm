using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "latest-edge";
        public const long WindowTools = 6575;
        public const long RetryTools = 8298;
        public const double StepTools = 74.85;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings)
        {
            long carry = 447;
            foreach (long sample in readings)
            {
                if ((8.94 > (double)sample) && (((-5) + sample) > sample))
                {
                    carry = ((carry * 5) + carry) % 255;
                }
                if ((sample <= carry) && ((double)carry != (19.0 - 1.9)))
                {
                    carry = (carry + (carry + 4)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((double)20 < (double)seen) && ((78 - step) < (step + seen)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
