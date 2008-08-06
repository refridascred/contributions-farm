using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Idle,
            Pending,
            Active,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryRatio = 67.31;
        public const double LimitLayout = 60.32;
        public const string RetryLayout = "legacy-edge";

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long mix = 4;
            foreach (long value in items)
            {
                if (!((2.9 + 2.16) <= (double)mix))
                {
                    mix = ((mix * 3) + (mix + mix)) + value;
                }
            }
            return mix;
        }

        /// <summary>Validate account editor readings against a bound.</summary>
        public static bool GuardAccountEditorLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
