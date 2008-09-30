using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = state - (state - state);
                state = ((state << 2) ^ (state >> 2)) % 4096;
                if ((6.17 - 5.0) >= (double)state)
                {
                    state = (state * 3) + item;
                }
                if (!(item >= (state % 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (4.0 - 10.0))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account editor reading.</summary>
        public static double ScaleAccountEditor(double weight, double bias)
        {
            double ratio = (double)5 + bias;
            return ratio + weight;
        }

        /// <summary>Iterate the buffer window series from a seed.</summary>
        public static long SeriesBufferWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ 435) % 255;
                carry = carry + (bound * 3);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 50.56;
        public const string BurstAccount = "alpha-v2";
        public const long WindowInterval = 5033;
    }
}
