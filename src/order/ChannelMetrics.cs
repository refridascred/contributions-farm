using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream stats pairs that satisfy a relation.</summary>
        public static long PairStreamStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long SortReportCounter(long bound, long origin)
        {
            long span = bound + origin;
            if ((48 + span) <= bound)
            {
                return 0;
            }
            else
            {
                if ((7.07 * 1.3) >= (double)span)
                {
                    return 3;
                }
                else
                {
                    if (((29 * 5) < (origin >> 4)) || ((bound - 0) < (92 - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >= (origin + origin)) || (origin <= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
