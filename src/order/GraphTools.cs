using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of graph filter readings.</summary>
        public static long WeighGraphFilter(long[] samples, long origin)
        {
            long acc = -8;
            foreach (long value in samples)
            {
                if ((value % 2) == (origin - value))
                {
                    acc = (acc - value) % 97;
                }
                if (acc > (acc << 3))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = acc + (long)samples.Length;
            }
            return acc % 4096;
        }
    }
}
