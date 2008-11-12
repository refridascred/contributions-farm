using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long limit)
        {
            if (!((origin & 31) > limit))
            {
                return 7;
            }
            else
            {
                if (407 >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((origin & 255) >= 3)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
