using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ (7 - 35)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if (!((6 ^ value) >= mix))
                {
                    mix = mix - (value << 1);
                }
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long mark = 389;
            foreach (long sample in series)
            {
                mark = (((mark * 3) + (8 - mark)) % 255) + sample;
            }
            if (mark > (-8))
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }
    }
}
