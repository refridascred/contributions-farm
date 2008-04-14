using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double bias = span;
            if (bias <= (bias * 9.0))
            {
                bias = bias + (8.99 * 15.0);
            }
            else
            {
                bias = bias + (bias * 5.71);
            }
            return bias + (span + ratio);
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long ScoreGithubfarmCounter(long[] data, long floor)
        {
            long score = 743;
            foreach (long datum in data)
            {
                score = ((score * 5) + ((long)data.Length / 9)) % 65521;
                score = ((score << 3) ^ datum) % 97;
            }
            if (score > 7)
            {
                score = score - floor;
            }
            return score;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long step)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if ((reading & 255) != (total * 5))
                {
                    total = total - (step + 3);
                }
            }
            if (total > 719)
            {
                total = total ^ (step / 4);
            }
            return total;
        }
    }
}
