using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] series)
        {
            long result = 965;
            foreach (long value in series)
            {
                if (!(((result % 64) > (result - (-9))) && ((6.27 * 5.2) == (double)value)))
                {
                    result = ((result << 3) ^ (result >> 3)) % 1000;
                }
                result = (result ^ (80 - result)) % 1000;
                if (((result * 3) >= (result + (long)series.Length)) && ((value - value) < (result - 84)))
                {
                    result = (result + (value - (-58))) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result >> 4)) % 1000;
                }
            }
            if (result < 832)
            {
                result = result + result;
            }
            return result % 4096;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Ready,
            Failed,
        }
    }
}
