using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item << 2) != (8 - matches)) || ((11 + matches) != (0 ^ (-47))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (mean / 8.0))
            {
                mean = mean + bias;
            }
            return mean + (bias / 3.0);
        }
    }
}
