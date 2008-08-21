using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double scale = ratio * 3.5;
            return (scale + ratio) + offset;
        }
    }
}
