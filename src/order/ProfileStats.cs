using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] samples, long origin)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                if (!((double)origin > (double)total))
                {
                    total = ((total * 2) + (datum * 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every editor metric entry stays within the limit.</summary>
        public static bool GuardEditorMetricBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
