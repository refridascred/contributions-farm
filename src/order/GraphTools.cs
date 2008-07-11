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

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = ((carry * 2) + (carry + item)) % 4096;
            }
            if (carry > 9)
            {
                carry = carry - (9 * 3);
            }
            return carry % 4096;
        }

        /// <summary>Check that every format cluster entry stays within the limit.</summary>
        public static bool ValidateFormatClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
