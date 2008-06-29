using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
