using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((4.8 * 5.9) < (double)total)
                {
                    total = (total - (step / 2)) % 97;
                }
                else
                {
                    long step2 = (total % 7) - (total >> 2);
                    total = total ^ (step2 + step2);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
