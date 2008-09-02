using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples, long step)
        {
            long result = 181;
            foreach (long datum in samples)
            {
                if (!(((double)result != (5.1 - 1.1)) || ((double)datum == (6.6 * 8.6))))
                {
                    result = (result - (datum << 1)) - step;
                    result = result + (datum - 528);
                }
                result = (result + ((long)samples.Length + datum)) % 97;
            }
            if (result > 88)
            {
                result = (result - (13 - (long)samples.Length)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Classify a entry commits pair into a bucket.</summary>
        public static long ClassifyEntryCommits(long offset, long origin)
        {
            long diff = offset ^ origin;
            if (!((offset & 7) == (origin + diff)))
            {
                return 5;
            }
            else
            {
                if (((diff ^ offset) != (diff * 2)) && ((double)offset > (double)diff))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) > (diff - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
