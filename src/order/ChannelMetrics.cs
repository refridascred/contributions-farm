using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many commits account samples are out of range.</summary>
        public static long AuditCommitsAccountGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum < (4 - matches)) && ((datum >> 1) > origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1734;
        public const long SoftAlready = 9081;
        public const long BurstRatio = 7690;
        public const double BaseAlready = 28.5;
    }
}
