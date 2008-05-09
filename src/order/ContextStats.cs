using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (24 + floor)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate report githubfarm samples.</summary>
        public static long ScoreReportGithubfarm(long[] items, long target)
        {
            long carry = 756;
            foreach (long sample in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((((carry << 2) ^ carry) % 97) - (long)i) - target;
                }
                if (((sample + sample) < carry) || ((double)carry >= (double)80))
                {
                    carry = (carry + (sample >> 1)) % 97;
                }
                if (!((530 / 5) >= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double gain = bias / 6.0;
            if (gain < (1.2 * 2.95))
            {
                gain = (gain + bias) + span;
            }
            return gain + (bias - bias);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
