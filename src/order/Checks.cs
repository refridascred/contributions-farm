using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values, long origin)
        {
            long mark = 732;
            foreach (long entry in values)
            {
                mark = (((mark - ((long)values.Length + 7)) % 101) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 1568;
        public const long WindowFarm = 2746;
        public const double IdleFarm = 69.8;
        public const long DefaultFarm = 7168;

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double scale = gain + gain;
            if (scale > (double)5)
            {
                scale = scale - (double)435;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (5.0 - gain)) - (double)(long)i;
            }
            return scale + span;
        }
    }
}
