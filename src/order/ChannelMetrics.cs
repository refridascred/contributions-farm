using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Idle,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseRatio = 8682;
        public const long WindowCount = 5389;
        public const double DefaultScore = 75.39;
        public const long BurstOrder = 5645;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
