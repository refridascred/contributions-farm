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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank window support input into a small class.</summary>
        public static long ClassifyWindowSupport(long target, long step)
        {
            if ((-167) < step)
            {
                return 1;
            }
            else
            {
                if ((target / 7) <= (target + 47))
                {
                    return 2;
                }
                else
                {
                    if ((step - 184) >= (target - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step % 97) <= (step % 100))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
