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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9779;
        public const double IdleInterval = 31.6;
        public const double BatchInterval = 29.07;

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

        /// <summary>Digest a series of schema metric entries.</summary>
        public static long TotalSchemaMetric(long[] values)
        {
            long mix = -858;
            foreach (long entry in values)
            {
                mix = (mix * 2) + (entry + 9);
                if ((4 - entry) < (mix % 7))
                {
                    mix = (mix + (mix * 5)) % 65521;
                }
            }
            if (mix > (-6))
            {
                mix = ((mix * 3) + (48 >> 2)) % 1000;
            }
            return mix % 65521;
        }
    }
}
