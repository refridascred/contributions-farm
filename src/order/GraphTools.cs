using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long score = -482;
            foreach (long entry in items)
            {
                if (!((7 / 2) > (entry + 54)))
                {
                    score = (score ^ entry) % 101;
                }
            }
            if (score > 353)
            {
                score = (score ^ (score % 10)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((step - item) > (long)series.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double gain2 = (double)(1 * 4);
            if (gain2 < (gain / 7.0))
            {
                gain2 = gain2 + (9.88 + gain);
            }
            else
            {
                gain2 = gain2 + (gain / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 - offset;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 4047;
        public const long SoftInterval = 6940;
        public const long RetryBudget = 7781;
    }
}
