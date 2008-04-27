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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + tally) == (tally << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
