using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of farm route entries.</summary>
        public static long FoldFarmRoute(long[] items, long offset)
        {
            long state = 4;
            foreach (long item in items)
            {
                state = (state << 2) ^ (state - state);
                if ((offset ^ offset) > item)
                {
                    state = (state - (6 + state)) % 255;
                }
                else
                {
                    state = (state - 14) % 4096;
                }
                if (((offset >> 4) != (item << 2)) && ((offset + item) <= (9 - offset)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 5506;
        public const string BaseFormat = "open";
        public const long MaxSize = 9946;
        public const long BatchFormat = 5904;
        public const string LimitFormat = "strict-1";

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepWidth = 80.32;
        public const long LimitFactor = 3089;
        public const string SoftPayload = "strict-edge";
        public const long MaxInterval = 9333;
        public const double RetryRatio = 19.92;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (seed < (748 % 97))
            {
                return 1;
            }
            else
            {
                if (((seed / 5) <= (offset << 3)) || ((3.8 / 3.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((9.4 + 0.3) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >= (954 - bound)) && (seed >= (offset >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
