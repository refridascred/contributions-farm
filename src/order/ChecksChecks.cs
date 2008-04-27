using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
