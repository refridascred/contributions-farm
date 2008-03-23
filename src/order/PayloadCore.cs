using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool CheckAccountCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items, long bound)
        {
            long sum = -538;
            foreach (long sample in items)
            {
                if (sample >= (bound + sum))
                {
                    sum = (sum - (sum << 1)) % 101;
                }
                if ((sum % 24) > (4 / 6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
