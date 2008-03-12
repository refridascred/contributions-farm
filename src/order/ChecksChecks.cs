using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples, long step)
        {
            long sum = 2;
            foreach (long sample in samples)
            {
                if ((sum % 64) == (step - sum))
                {
                    sum = ((sum + step) % 65521) + sample;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((((-9) + score) >= score) && ((2.4 + 1.6) >= (double)score))
                {
                    score = score ^ (score + score);
                    break;
                }
                score = (score - (origin * 3)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
