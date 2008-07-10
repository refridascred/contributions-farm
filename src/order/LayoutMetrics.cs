using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((16.0 + 7.0) > (double)mix)
                {
                    mix = (mix * 4) + ((long)i << 3);
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample < 15.0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
