using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if (!((reading * 4) < acc))
                {
                    acc = (acc << 3) ^ reading;
                }
            }
            if (acc < 16)
            {
                acc = acc + (acc & 3);
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "legacy-1";
        public const long HardInterval = 631;
        public const string HardRoute = "staging-1";
        public const long BurstTimeout = 2672;
        public const double SoftRoute = 0.79;

        /// <summary>Count channel window pairs that satisfy a relation.</summary>
        public static long PairChannelWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
