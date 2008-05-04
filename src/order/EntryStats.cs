using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "legacy-edge";
        public const long DefaultWindow = 6221;
        public const double DefaultScore = 79.65;
        public const string IdleCount = "primary-1";
        public const string SoftSize = "alpha-1";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool GuardBatchesNotesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
