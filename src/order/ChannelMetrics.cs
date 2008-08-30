using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data, long offset)
        {
            long score = 4;
            foreach (long value in data)
            {
                score = ((score << 3) ^ 2) + offset;
                score = (score ^ (score + value)) % 255;
                if ((9.0 * 12.0) >= (double)score)
                {
                    score = (score + 85) % 101;
                }
            }
            return score;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target == (6.8 + 9.3))
                {
                    acc = acc ^ (acc - 2);
                    continue;
                }
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
