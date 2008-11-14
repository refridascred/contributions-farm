using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long step)
        {
            if ((offset < (offset + offset)) && ((41 + offset) < offset))
            {
                return 8;
            }
            else
            {
                if (!((step - offset) != (69 + (-40))))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) <= (1 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long sum = 14;
            foreach (long datum in readings)
            {
                sum = (sum ^ (sum - sum)) % 4096;
                if ((datum >> 5) < (1 * 4))
                {
                    sum = (sum << 3) ^ (sum % 2);
                }
                if (!((sum + datum) <= (datum + sum)))
                {
                    sum = (sum * 4) + (sum + sum);
                }
                else
                {
                    sum = ((sum << 2) ^ (datum >> 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double ratio = (span / 8.0) / 8.0;
            if (ratio < 4.64)
            {
                ratio = ratio + (bias - 9.0);
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - span;
        }
    }
}
