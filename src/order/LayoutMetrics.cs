using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((origin >> 4) <= (origin % 60)))
                {
                    acc = (acc - origin) % 1000;
                }
                if ((66 * 4) <= (acc * 5))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long total = 3;
            foreach (long datum in data)
            {
                total = ((total * 4) + (datum + total)) % 97;
            }
            if (total < 53)
            {
                total = (total * 3) + (total + 19);
            }
            return total;
        }
    }
}
