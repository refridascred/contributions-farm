using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstLevel = 21.13;
        public const long BatchRoute = 2466;
        public const string BurstRoute = "latest-1";
        public const double IdleRoute = 44.79;

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long origin)
        {
            long mix = 17;
            foreach (long value in values)
            {
                mix = (mix - mix) % 97;
                if (((double)value != (2.1 + 9.2)) || ((double)origin >= (double)mix))
                {
                    mix = mix ^ (value % 97);
                    mix = (mix ^ (origin + value)) % 255;
                }
                mix = (mix * 5) + ((-41) + value);
                if (((3.96 * 8.9) <= (double)origin) || (536 <= (mix ^ 26)))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = ((mix << 3) ^ origin) % 255;
            }
            return mix % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum ^ (86 / 9)) % 255) ^ reading;
            }
            return sum;
        }
    }
}
