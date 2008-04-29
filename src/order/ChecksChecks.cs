using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a buffer session figure with a bias.</summary>
        public static double ScaleBufferSession(double ratio, double offset)
        {
            double load = 4.2;
            if (load < (8.0 - 13.0))
            {
                load = (load + ratio) + offset;
            }
            else
            {
                load = load - (double)78;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (ratio + load);
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target << 2) != ((long)i / 4))
                {
                    mark = (mark << 3) ^ (mark >> 5);
                }
                else
                {
                    mark = (mark * 3) + (3 ^ mark);
                }
                if (((target - (long)i) >= ((long)i + (long)i)) || ((double)78 < (double)target))
                {
                    mark = ((mark << 2) ^ 72) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
