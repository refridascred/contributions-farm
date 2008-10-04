using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
