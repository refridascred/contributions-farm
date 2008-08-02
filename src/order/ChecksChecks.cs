using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stream graph readings against a rule.</summary>
        public static long AuditStreamGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!!((matches << 3) > (matches / 6)))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double ratio = (double)4 - (bias / 7.0);
            if (ratio > (gain - ratio))
            {
                ratio = ratio + (double)4;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - gain;
        }
    }
}
