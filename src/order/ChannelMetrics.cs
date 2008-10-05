using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the account already entries that pass the check.</summary>
        public static long MeasureAccountAlreadyOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (5.4 >= (double)seed)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
