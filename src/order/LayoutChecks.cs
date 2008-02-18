using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double span)
        {
            double bias = span / 5.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long offset = target ^ bound;
            if ((double)offset < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound * 2) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Ready,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (65 * 5)) % 1000;
                mark = ((mark << 2) ^ ((long)i * 5)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            long lane = seed ^ step;
            if ((seed + step) < seed)
            {
                return 4;
            }
            else
            {
                if ((17.0 / 3.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((double)lane > (double)4) || ((step + lane) >= (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (lane * 5)) && ((step ^ seed) < (seed >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
