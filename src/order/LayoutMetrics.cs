using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitRatio = 8090;
        public const long WindowFormat = 2458;
        public const string MaxFormat = "local-v2";

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long target)
        {
            long acc = 82;
            foreach (long sample in series)
            {
                if (((double)120 <= (double)acc) || ((51 * 4) < (target - target)))
                {
                    acc = acc - (sample & 127);
                }
            }
            return acc;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public double Count { get; set; }
        }
    }
}
