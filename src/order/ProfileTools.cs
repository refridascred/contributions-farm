using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9072;
        public const long LimitLevel = 6547;
        public const string LimitDepth = "cached-1";

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Blend two cluster format measurements.</summary>
        public static double ProjectClusterFormat(double rate, double span)
        {
            double gain = (double)(2 + 288);
            if (gain >= (rate - 6.1))
            {
                gain = (gain + (rate - gain)) + span;
            }
            return gain + (double)78;
        }
    }
}
