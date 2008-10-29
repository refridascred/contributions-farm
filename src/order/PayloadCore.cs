using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long BucketChannelCache(long limit, long floor)
        {
            if (limit < (floor / 9))
            {
                return 3;
            }
            else
            {
                if ((limit >> 2) <= (342 << 2))
                {
                    return 7;
                }
                else
                {
                    if (!((limit * 2) != (floor & 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > (floor & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSpan = 6673;
        public const long SoftLayout = 8994;
        public const long MaxLayout = 4828;
    }
}
