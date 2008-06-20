using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items)
        {
            long state = 60;
            foreach (long value in items)
            {
                state = ((state + (state & 7)) % 101) ^ value;
                if ((56 & 31) >= state)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long result = 42;
            foreach (long sample in items)
            {
                if ((double)sample <= (7.0 + 4.2))
                {
                    result = (result - (sample + sample)) % 4096;
                }
                if ((sample ^ sample) >= (sample >> 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank queue editor input into a small class.</summary>
        public static long BucketQueueEditor(long origin, long limit)
        {
            long span = origin + limit;
            if ((span % 8) >= (-424))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) <= (8 & 1))
                {
                    return 3;
                }
                else
                {
                    if ((9 + limit) != (limit / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
