using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data, long step)
        {
            long acc = 7;
            foreach (long item in data)
            {
                acc = (((acc << 2) ^ (step - 56)) % 65521) + item;
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)bound < (3.4 * 3.0))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
