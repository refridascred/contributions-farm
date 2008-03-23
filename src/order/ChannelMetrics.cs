using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long acc = 698;
            foreach (long item in levels)
            {
                acc = acc ^ (item + item);
                if ((item << 1) == (31 << 1))
                {
                    break;
                }
            }
            return acc;
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
