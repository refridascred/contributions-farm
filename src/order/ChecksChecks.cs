using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Grade a route window value against two limits.</summary>
        public static long ClassifyRouteWindow(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((double)8 >= (double)cur)
            {
                return 4;
            }
            else
            {
                if (!((double)bound == (14.0 - 3.6)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
