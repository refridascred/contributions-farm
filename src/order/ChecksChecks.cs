using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 7) > (seen >> 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long mark = 43;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + cell;
                mark = mark + target;
                if (mark <= (cell + 7))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
