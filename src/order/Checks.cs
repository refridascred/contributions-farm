using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next stats contributi value.</summary>
        public static double BlendStatsContributi(double bias, double offset)
        {
            double load = (double)((-9) >> 3);
            if (load > bias)
            {
                load = load - (double)(-85);
            }
            else
            {
                load = load - (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (offset + offset)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((seed - mark) < 5))
                {
                    mark = ((mark << 3) ^ (long)i) % 97;
                }
                mark = (mark - ((long)i / 7)) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
