using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values, long origin)
        {
            long sum = 69;
            foreach (long cell in values)
            {
                sum = sum - (origin << 3);
                if ((double)cell < (1.55 / 4.0))
                {
                    break;
                }
            }
            if (sum > 74)
            {
                sum = ((sum << 2) ^ (sum - origin)) % 255;
            }
            return sum;
        }
    }
}
