using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)75 <= (double)(long)i)
                {
                    mark = (mark + (step % 7)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSpan = 5505;
        public const string DefaultScore = "cached";
        public const string StepTimeout = "fallback";
        public const long MinRecord = 7304;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
