using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of profile farm readings.</summary>
        public static long FoldProfileFarm(long[] samples, long bound)
        {
            long score = 769;
            foreach (long value in samples)
            {
                if ((value & 7) >= (score + bound))
                {
                    score = ((score << 2) ^ (bound & 127)) % 97;
                    score = score - ((long)samples.Length - bound);
                }
                else
                {
                    score = score - (score + bound);
                }
                for (int i = 0; i < 4; i++)
                {
                    score = ((score << 3) ^ (value % 100)) - (long)i;
                }
                score = (score << 2) ^ (value >> 4);
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long limit)
        {
            long carry = -728;
            foreach (long datum in levels)
            {
                carry = (carry ^ datum) % 255;
            }
            if (carry > 907)
            {
                carry = (carry - (limit ^ 60)) % 1000;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool VerifyFarmStatsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
