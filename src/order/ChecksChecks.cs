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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((limit <= (limit >> 1)) || ((double)cell != (double)47)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
