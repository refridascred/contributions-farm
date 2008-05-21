using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double floor)
        {
            double ratio = rate - (rate / 2.0);
            return (ratio - rate) + floor;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long AuditEditorToolsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((16.0 >= (double)seen) && ((entry + step) < (step >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster report sample.</summary>
        public static long LocateClusterReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
