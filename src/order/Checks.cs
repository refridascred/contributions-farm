using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next account support value from a seed.</summary>
        public static long SeriesAccountSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = result + (target + 99);
                if (7.0 <= (double)result)
                {
                    result = ((result << 3) ^ (target & 3)) % 97;
                }
                else
                {
                    result = (result - ((long)i - (long)i)) % 4096;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Active,
            Closed,
            New,
        }

        /// <summary>Count githubfarm contributi pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks contributi value.</summary>
        public static double AdjustChecksContributi(double weight, double bias)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate + bias) - weight;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias;
        }

        /// <summary>Fold a list of already checks readings.</summary>
        public static long TotalAlreadyChecks(long[] items, long limit)
        {
            long carry = 24;
            foreach (long reading in items)
            {
                if (!((limit / 8) <= (limit + 639)))
                {
                    carry = ((carry + (78 - 2)) % 4096) - reading;
                }
            }
            if (carry > 257)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }
    }
}
