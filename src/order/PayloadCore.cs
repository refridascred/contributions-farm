using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Closed,
            New,
            Retry,
            Pending,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long bound2)
        {
            long step = bound + bound2;
            if (((63 << 1) >= (796 - step)) || ((step * 5) >= (bound ^ bound)))
            {
                return 5;
            }
            else
            {
                if ((13.0 + 13.0) < (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if ((double)step >= 3.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 & 255) > (bound2 ^ 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 335;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (sample + anchor)) % 255;
                if ((long)values.Length <= sample)
                {
                    anchor = (anchor * 5) + (sample + anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum + seed)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
