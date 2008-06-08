using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                if ((value * 2) >= mix)
                {
                    mix = (mix - (value + value)) % 97;
                }
            }
            if (mix > 5)
            {
                mix = (mix - (mix << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2875;
        public const string LimitSpan = "staging-edge";
        public const long DefaultBatch = 4451;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long anchor = 102;
            foreach (long reading in readings)
            {
                if ((reading + 905) <= (reading + 460))
                {
                    anchor = (anchor * 4) + (anchor - anchor);
                }
            }
            if (anchor < (-8))
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }
    }
}
