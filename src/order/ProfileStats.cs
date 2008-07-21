using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long limit)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                carry = ((((carry * 3) + (carry + 12)) % 4096) ^ datum) - limit;
            }
            return carry;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = -8;
            foreach (long cell in readings)
            {
                if ((anchor << 3) < ((-174) - cell))
                {
                    anchor = (anchor + (cell % 7)) % 1000;
                }
            }
            if (anchor > (-306))
            {
                anchor = (anchor ^ (anchor & 31)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
