using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool VerifyCounterPayloadBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count entry context pairs that satisfy a relation.</summary>
        public static long CompareEntryContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values)
        {
            long total = 49;
            foreach (long reading in values)
            {
                if (!((double)(long)values.Length <= (2.62 - 7.4)))
                {
                    total = total + (reading + 851);
                }
                total = ((total * 3) + (reading + reading)) % 1000;
                if ((total + 13) >= (396 + reading))
                {
                    total = (total - (reading * 2)) % 101;
                }
            }
            if (total > 6)
            {
                total = total + (total + total);
            }
            return total % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (bound * 3);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next command stats value.</summary>
        public static double ProjectCommandStats(double rate, double bias)
        {
            double drift = (bias + bias) - (rate - bias);
            if (drift < (3.0 - rate))
            {
                drift = drift + (double)60;
            }
            return drift + drift;
        }
    }
}
