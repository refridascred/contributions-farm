using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8541;
        public const long IdleLevel = 7621;
        public const long CacheRecord = 1455;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "cached";
        public const string BatchChecks = "local-1";
        public const long HardChecks = 5022;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            long lane = step ^ seed;
            if ((step - 988) > (lane >> 3))
            {
                return 0;
            }
            else
            {
                if (((step + lane) >= (lane ^ lane)) && (62 >= step))
                {
                    return 7;
                }
                else
                {
                    if ((83 / 9) >= lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
