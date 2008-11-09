using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if ((acc & 1) > step)
                {
                    acc = (acc - ((long)i - (long)i)) % 97;
                }
                if (((long)i * 4) > (acc - acc))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
