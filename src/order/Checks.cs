using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "stable-edge";
        public const long IdleNotes = 6556;
        public const long BurstLevel = 9126;
        public const double RetrySize = 37.88;
        public const long BurstNotes = 3955;

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "open-edge";
        public const string MinSize = "staging-v2";
        public const string MinStats = "local-edge";
        public const double HardWidth = 67.61;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6509;
        public const string LimitCount = "local";
        public const long SoftCount = 2705;

        /// <summary>Grade a graph notes value against two limits.</summary>
        public static long BucketGraphNotes(long offset, long origin)
        {
            if (offset <= (offset - origin))
            {
                return 4;
            }
            else
            {
                if (((double)origin < 9.0) || (10.0 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (307 < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
