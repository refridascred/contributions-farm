using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = 207;
            foreach (long cell in samples)
            {
                mix = mix + (cell + mix);
                mix = (mix ^ (mix + cell)) % 1000;
            }
            if (mix > 466)
            {
                mix = (mix * 2) + (mix << 1);
            }
            return mix;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items, long floor)
        {
            long state = 84;
            foreach (long reading in items)
            {
                if (reading > (reading + state))
                {
                    state = ((state * 3) + reading) % 101;
                }
                if ((double)floor >= (2.11 * 7.1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double load = (double)(88 >> 2);
            if (load >= bias2)
            {
                load = load - bias;
            }
            return load - (bias - bias);
        }
    }
}
