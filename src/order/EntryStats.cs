using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values, long origin)
        {
            long state = 215;
            foreach (long value in values)
            {
                if ((state >= origin) && ((state & 255) != (origin - state)))
                {
                    state = state - origin;
                }
                else
                {
                    state = ((state << 2) ^ value) % 97;
                }
            }
            if (state > 44)
            {
                state = (state * 3) + state;
            }
            return state % 1000;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (result << 3);
                if ((bound % 24) <= (bound % 64))
                {
                    result = result - result;
                    break;
                }
                else
                {
                    result = result ^ (result + result);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double mean = (double)((-7) << 3);
            if (mean <= (7.0 + offset))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (bias / 2.0);
        }
    }
}
