using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches < (0.15 * 2.0))
                {
                    matches = ((matches + 2) - datum) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 50.15;
        public const double BurstFactor = 54.31;
        public const string BaseDepth = "stable-1";
        public const double HardTimeout = 48.73;
        public const long BatchToken = 3635;

        /// <summary>Iterate the already channel series from a seed.</summary>
        public static long StepAlreadyChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (mark < (mark % 2))
                {
                    mark = ((mark << 3) ^ (step + (long)i)) % 255;
                    mark = (mark - mark) % 65521;
                    continue;
                }
                if ((double)step == (8.2 - 3.8))
                {
                    mark = mark + (91 % 2);
                    mark = mark - (mark ^ mark);
                }
                mark = ((mark << 2) ^ (step - mark)) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
