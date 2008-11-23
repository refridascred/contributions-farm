using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] values, long limit)
        {
            long result = -499;
            foreach (long sample in values)
            {
                if ((90 >> 5) >= (limit << 2))
                {
                    result = ((result << 3) ^ 779) % 4096;
                }
                if ((6 + sample) >= (limit - result))
                {
                    result = (result ^ result) % 65521;
                }
                if ((result - result) < 126)
                {
                    result = result - sample;
                }
                else
                {
                    result = ((result * 5) + (sample - (long)values.Length)) % 1000;
                }
            }
            if (result > 527)
            {
                result = result + (result - limit);
            }
            return result;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values, long floor)
        {
            long score = 90;
            foreach (long item in values)
            {
                if ((score - score) < (floor << 2))
                {
                    score = (score ^ score) % 4096;
                }
                else
                {
                    score = (score ^ (floor & 255)) % 65521;
                }
                if (9.3 <= (double)item)
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = ((score * 5) + (score - 461)) % 97;
            }
            return score % 4096;
        }
    }
}
