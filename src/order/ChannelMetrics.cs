using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data, long origin)
        {
            long acc = 925;
            foreach (long reading in data)
            {
                if ((origin <= (reading - reading)) && ((reading - 3) >= origin))
                {
                    acc = (acc ^ origin) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "standard-v2";
        public const long LimitInterval = 3191;
        public const long LimitEditor = 3032;
        public const long MaxEditor = 7278;
        public const long DefaultEditor = 429;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
