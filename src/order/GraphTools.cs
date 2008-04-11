using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long limit)
        {
            long bound = floor - limit;
            if (52 >= (floor & 3))
            {
                return 7;
            }
            else
            {
                if (bound <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((0 * 5) < (bound ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 7601;
        public const double DefaultWindow = 21.17;
        public const double RetryWindow = 49.17;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - acc;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
