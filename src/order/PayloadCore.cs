using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long RollCounterContext(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next schema support value from a seed.</summary>
        public static long IterateSchemaSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples, long limit)
        {
            long score = 711;
            foreach (long entry in samples)
            {
                if ((limit * 4) < (limit & 1))
                {
                    score = (score - (score - limit)) - entry;
                }
            }
            if (score > 248)
            {
                score = score - (score + 2);
            }
            return score;
        }

        /// <summary>Scale a metrics buffer figure with a bias.</summary>
        public static double SmoothMetricsBuffer(double gain, double offset)
        {
            double rate = offset;
            if (rate <= (gain - gain))
            {
                rate = rate - (double)8;
            }
            return rate + gain;
        }
    }
}
