using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 18.33;
        public const long RetryQueue = 6661;
        public const long WindowQueue = 4791;
        public const long CacheQueue = 8924;
        public const long BaseLevel = 5220;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                if ((target - target) > (mark + datum))
                {
                    mark = ((mark << 2) ^ (target + datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
