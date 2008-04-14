using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a tools support value against two limits.</summary>
        public static long GradeToolsSupport(long limit, long target)
        {
            if ((1.0 - 15.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((limit / 2) < limit) || ((target * 3) <= (limit << 1)))
                {
                    return 0;
                }
                else
                {
                    if (!((limit ^ limit) > (limit / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
