using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen >> 1) < (entry >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double drift = (double)(10 * 4);
            if (drift < drift)
            {
                drift = (drift + drift) - offset;
            }
            return drift - (bias * 5.34);
        }

        /// <summary>Iterate the editor notes series from a seed.</summary>
        public static long StepEditorNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - (target >> 1);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (((4.9 - 10.0) != (double)bound2) && ((offset - bound2) < (3 + bound)))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (5.41 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) != (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
