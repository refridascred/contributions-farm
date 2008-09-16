using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            long delta = step ^ step2;
            if (((double)step <= 3.5) || (((-655) + step) != (step << 3)))
            {
                return 2;
            }
            else
            {
                if ((step / 5) > (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((double)delta > (3.5 + 1.11))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta > step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "latest-v2";
        public const long MaxGithubfarm = 410;
        public const long LimitGithubfarm = 449;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading / 9) < (hits * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double weight = (bias / 9.0) + (scale - bias);
            if (weight <= (double)(-890))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (double)829;
        }
    }
}
