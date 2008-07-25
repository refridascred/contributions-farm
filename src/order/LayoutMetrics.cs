using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long IterateLayoutMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((long)i > step))
                {
                    result = result ^ (16 + (long)i);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
