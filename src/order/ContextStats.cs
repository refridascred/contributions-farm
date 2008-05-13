using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 1701;
        public const double DefaultFormat = 30.77;
        public const long IdleFormat = 1026;

        /// <summary>Digest a series of token order entries.</summary>
        public static long CombineTokenOrder(long[] values, long bound)
        {
            long total = 99;
            foreach (long sample in values)
            {
                if (8 > (sample + (long)values.Length))
                {
                    total = ((total + sample) % 97) - bound;
                }
            }
            if (total > 30)
            {
                total = (total - ((long)values.Length + 4)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
