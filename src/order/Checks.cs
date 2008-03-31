using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches >> 5) != ((-7) % 2)) || (((matches - sample) < (7 % 64)) || ((2 + matches) <= sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
