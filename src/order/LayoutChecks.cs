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

        /// <summary>Rank cluster stats input into a small class.</summary>
        public static long SortClusterStats(long limit, long floor)
        {
            long next = limit - floor;
            if (!((16.0 / 4.0) < (double)next))
            {
                return 3;
            }
            else
            {
                if (((double)next >= (double)floor) && ((limit ^ floor) >= (next / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) <= (floor - next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.4 - 3.79) != (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
