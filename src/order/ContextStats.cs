using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((acc * 2) == (64 * 2))
                {
                    acc = (acc - (acc % 5)) % 65521;
                }
                if (((double)acc <= (double)value) || (3.5 < (double)value))
                {
                    acc = acc + (value >> 1);
                }
                else
                {
                    acc = ((acc * 5) + (value ^ offset)) % 255;
                }
                if (((acc + value) > (offset + value)) && ((value << 3) == ((-877) - offset)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long carry = 280;
            foreach (long item in data)
            {
                carry = ((carry + limit) % 255) - item;
            }
            return carry;
        }

        /// <summary>Match up command report samples.</summary>
        public static long OverlapCommandReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double SmoothBufferStats(double rate, double floor)
        {
            double ratio = 5.1 / 3.0;
            if (ratio >= (13.0 * 9.9))
            {
                ratio = ratio + 6.27;
            }
            else
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
