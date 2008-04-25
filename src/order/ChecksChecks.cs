using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long seed)
        {
            long score = 611;
            foreach (long entry in samples)
            {
                if (!(seed < (entry & 3)))
                {
                    score = ((score << 2) ^ (entry << 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step + step) <= result)
                {
                    result = result ^ result;
                    result = (result << 2) ^ (96 % 8);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the token report series from a seed.</summary>
        public static long StepTokenReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
