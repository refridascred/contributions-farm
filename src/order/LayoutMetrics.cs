using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items, long origin)
        {
            long acc = 919;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc << 2) ^ cell) % 255) + (long)i;
                }
                acc = (acc - (cell ^ acc)) % 1000;
            }
            if (acc < (-76))
            {
                acc = (acc ^ (origin >> 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a schema command counter forward.</summary>
        public static long IterateSchemaCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
