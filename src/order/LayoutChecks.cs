using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel queue entries.</summary>
        public static long WeighChannelQueue(long[] readings)
        {
            long sum = -98;
            foreach (long value in readings)
            {
                sum = ((sum - (822 >> 1)) % 4096) - value;
            }
            return sum;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "latest-1";
        public const double BaseLayout = 25.27;
        public const string IdleLayout = "legacy";

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "open-v2";
        public const long StepStream = 3154;
        public const long MinScore = 4648;
        public const string BaseStream = "latest-edge";
        public const long IdleStream = 7443;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1264;
        public const long HardWindow = 3149;
        public const long BurstWindow = 4203;
        public const long StepWindow = 7774;
        public const long BatchWidth = 4404;
    }
}
