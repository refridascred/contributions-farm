using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels, long floor)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((71 + datum) < 1)
                {
                    state = ((state + (64 + 3)) % 101) + floor;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
