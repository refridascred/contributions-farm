using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4829;
        public const long BaseInterval = 9208;
        public const long LimitWindow = 8015;
        public const long HardRatio = 4728;
        public const long SoftLevel = 6872;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((4 + value) == ((-533) - 961))
                {
                    mix = (mix << 2) ^ 48;
                }
                else
                {
                    mix = ((mix * 4) + (bound + bound)) % 1000;
                }
            }
            if (mix > 504)
            {
                mix = ((mix * 3) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Rank token command input into a small class.</summary>
        public static long SortTokenCommand(long origin, long seed)
        {
            if (((double)seed > (6.0 - 13.0)) || ((seed + origin) < origin))
            {
                return 4;
            }
            else
            {
                if (origin <= ((-3) << 2))
                {
                    return 6;
                }
                else
                {
                    if (((origin + origin) < (-47)) || ((double)seed > (2.9 + 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
