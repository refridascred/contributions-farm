using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitRatio = 8202;
        public const double DefaultScore = 47.31;
        public const long WindowBuffer = 4864;

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
