using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 255) == (tally >> 4))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
