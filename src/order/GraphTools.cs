using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long WeighGraphEntry(long[] values)
        {
            long state = 31;
            foreach (long cell in values)
            {
                if (((state + state) > state) && (state <= (state & 7)))
                {
                    state = (state ^ (cell - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
