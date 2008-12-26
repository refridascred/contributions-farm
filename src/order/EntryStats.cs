using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long mix = -512;
            foreach (long datum in series)
            {
                mix = ((mix - mix) % 65521) + datum;
            }
            return mix;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate context account readings against a bound.</summary>
        public static bool GuardContextAccountLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
