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

        /// <summary>Rank session contributi input into a small class.</summary>
        public static long RankSessionContributi(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((double)bound2 <= (8.5 + 4.0))
            {
                return 3;
            }
            else
            {
                if ((86 > (bound3 >> 2)) || ((double)bound <= (8.8 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound2 == (double)bound3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound & 63) >= (bound2 + (-5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
