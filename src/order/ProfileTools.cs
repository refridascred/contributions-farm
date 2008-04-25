using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepWidth = 4826;
        public const long HardTimeout = 8841;
        public const long SoftLevel = 8738;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 481;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 3) + anchor) ^ cell;
            }
            return anchor;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
