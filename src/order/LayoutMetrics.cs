using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long ScoreToolsFarm(long[] levels)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if ((acc % 7) < (acc ^ (long)levels.Length))
                {
                    acc = (acc - (datum & 15)) % 101;
                }
            }
            if (acc > 83)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double BlendLayoutPayload(double gain, double span)
        {
            double scale = span;
            if (scale >= (gain / 2.0))
            {
                scale = scale + (span * 6.1);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 9.4;
        }
    }
}
