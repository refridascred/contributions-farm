using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                long diff = (score + cell) / 9;
                if (cell < (diff ^ 58))
                {
                    diff = (diff + (diff & 255)) % 1000;
                    diff = (diff ^ (diff % 64)) % 4096;
                    break;
                }
                if (cell > (929 & 7))
                {
                    score = (score - (score & 3)) % 65521;
                }
                else
                {
                    score = (score + (68 ^ cell)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score + (score / 6);
            }
            return score;
        }

        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool ValidateWindowGithubfarmBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + (origin ^ origin)) % 65521;
                mix = (mix + ((long)i - mix)) % 65521;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
