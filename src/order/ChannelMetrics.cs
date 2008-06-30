using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (offset >= (count + count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin % 12) < origin)
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (long)i) % 65521;
                    acc = acc - (origin % 60);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 85.37;
        public const double IdleEntry = 74.04;
        public const long HardEntry = 1254;
        public const double DefaultEntry = 87.84;
    }
}
