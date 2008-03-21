using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two report commits measurements.</summary>
        public static double AdjustReportCommits(double gain, double span)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + gain) + (double)(long)i) - span;
            }
            return load + 6.4;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(9.19 <= (double)hits))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = 767;
            foreach (long sample in levels)
            {
                if ((sample >> 2) > (mark + mark))
                {
                    mark = mark + (mark % 5);
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Ready,
            New,
            Paused,
            Idle,
        }
    }
}
