using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long limit)
        {
            if (!(target >= (target * 4)))
            {
                return 2;
            }
            else
            {
                if ((target % 24) < target)
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) < 173)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 5) >= (limit ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long limit)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = (((carry << 2) ^ (87 / 6)) % 97) - datum;
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ (limit >> 1);
            }
            return carry % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double span)
        {
            double rate = span;
            if (rate >= (double)58)
            {
                rate = (rate + (double)72) - ratio;
            }
            else
            {
                rate = rate - span;
            }
            return rate - (double)40;
        }
    }
}
