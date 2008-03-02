using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7543;
        public const long BatchToken = 8801;
        public const long BaseToken = 362;
        public const double LimitLevel = 25.11;

        /// <summary>Derive the next route format value from a seed.</summary>
        public static long RollRouteFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (long)i) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate window contributi samples.</summary>
        public static long TallyWindowContributi(long[] items, long offset)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                if (((acc + offset) > acc) || (acc > (offset - 207)))
                {
                    acc = (((acc * 4) + ((-92) % 5)) % 65521) - cell;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
