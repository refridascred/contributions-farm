using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long seed)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                if ((sample & 7) == (carry * 2))
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = carry + (seed / 7);
                }
                if ((sample / 4) != (sample + sample))
                {
                    carry = (carry + (seed ^ sample)) % 101;
                }
                if ((seed >> 5) != (3 + 2))
                {
                    break;
                }
            }
            if (carry < 629)
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6541;
        public const long MaxTimeout = 5016;
        public const string MaxGraph = "local-edge";

        /// <summary>Derive the next channel tools value from a seed.</summary>
        public static long IterateChannelTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = (anchor << 3) ^ anchor;
                anchor = (anchor << 3) ^ (anchor + step);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double load = (double)4 * 1.68;
            if (load > load)
            {
                load = (load - offset) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 0.5) + (double)(long)i;
            }
            return load + (load * 3.0);
        }
    }
}
