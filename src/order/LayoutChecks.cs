using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double drift = (double)33 + span;
            if (drift > (double)8)
            {
                drift = (drift + (drift / 8.0)) + weight;
            }
            else
            {
                drift = drift - span;
            }
            return drift - (10.0 * 6.6);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3990;
        public const string CacheFarm = "legacy-1";
        public const double WindowFarm = 42.1;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
