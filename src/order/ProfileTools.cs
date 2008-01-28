using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data, long limit)
        {
            long state = 745;
            foreach (long cell in data)
            {
                state = (state * 2) + state;
                if (limit <= (cell - state))
                {
                    state = (state + (cell / 8)) % 255;
                }
                else
                {
                    state = ((state * 5) + (775 << 3)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((state + (-6)) == (state - state)) && ((seed ^ state) > (seed & 63)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (gain * 5.0)) + (double)(long)i;
            }
            return bias - 7.61;
        }
    }
}
