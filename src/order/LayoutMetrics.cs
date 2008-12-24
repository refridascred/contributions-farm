using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double rate = bias;
            return (rate - (double)(-32)) + span;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 3) ^ (sum / 3)) ^ (long)i2;
                    sum = (sum << 2) ^ 30;
                }
                sum = sum + 598;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long AuditGithubfarmNotesMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)value > (8.4 * 7.9))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
