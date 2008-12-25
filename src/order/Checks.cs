using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((limit - value) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((result + step) <= result)
                {
                    break;
                }
                else
                {
                    result = result + ((-28) + step);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double bias3 = bias2 + (bias2 + bias2);
            if (bias3 >= (double)83)
            {
                bias3 = (bias3 + (double)412) + bias;
            }
            else
            {
                bias3 = bias3 + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - bias3) + (double)(long)i;
            }
            return bias3 + (bias2 * 3.54);
        }
    }
}
