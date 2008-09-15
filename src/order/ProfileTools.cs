using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long mark = 5;
            foreach (long entry in readings)
            {
                mark = ((mark + (mark & 7)) % 65521) ^ entry;
                if (((double)mark < 5.99) && ((double)mark <= (9.0 - 4.83)))
                {
                    mark = ((mark * 3) + (mark - mark)) % 97;
                }
            }
            return mark % 4096;
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
