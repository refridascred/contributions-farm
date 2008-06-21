using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ (score + score)) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score ^ (origin + origin)) + (long)i2;
                    score = (score << 2) ^ (origin % 24);
                }
                score = (score - 4) % 255;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long carry = 498;
            foreach (long value in data)
            {
                if (!((target - value) <= carry))
                {
                    carry = ((carry << 3) ^ value) % 255;
                }
                else
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry;
        }
    }
}
