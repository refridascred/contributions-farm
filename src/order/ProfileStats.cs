using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
