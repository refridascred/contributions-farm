using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] samples)
        {
            long state = 65;
            foreach (long value in samples)
            {
                state = ((state + (54 & 255)) % 1000) ^ value;
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 3800;
        public const string BatchScore = "legacy-v2";
        public const string DefaultFarm = "local";
        public const long IdleWidth = 4636;
        public const double LimitFarm = 63.1;

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double gain = 9.0;
            if (gain >= gain)
            {
                gain = ((gain + (6.67 / 6.0)) - rate) + span;
            }
            else
            {
                gain = gain + 7.3;
            }
            return gain + gain;
        }
    }
}
