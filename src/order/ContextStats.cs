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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
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

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Synced,
            Idle,
        }
    }
}
