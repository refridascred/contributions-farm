using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                long span = bound;
                if (!((54 + span) >= (21 >> 2)))
                {
                    total = total + span;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples)
        {
            long sum = 0;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + (cell + 21)) % 101;
                if (((double)cell == (4.0 / 6.0)) || (((long)samples.Length % 97) <= (sum * 2)))
                {
                    sum = (sum + cell) % 255;
                }
                else
                {
                    sum = sum - (cell - sum);
                }
                if ((sum + cell) != (sum << 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long bound)
        {
            if (3 > (41 + bound))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((717 > (origin + bound)) || ((double)29 > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + bound) < (origin % 7)) || ((origin + (-63)) > (17 / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
