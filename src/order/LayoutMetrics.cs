using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor <= 9.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
