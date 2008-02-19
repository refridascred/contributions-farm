using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6495;
        public const long HardNotes = 5268;
        public const long DefaultSpan = 9441;

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long sum = -9;
            foreach (long value in samples)
            {
                sum = (sum - (value & 1)) % 101;
            }
            if (sum < 750)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm batch values into a single score.</summary>
        public static long FoldGithubfarmBatch(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((67 + carry) == (carry * 4))
                {
                    carry = (carry ^ (carry - bound)) - datum;
                }
                carry = ((carry * 5) + (bound + bound)) % 97;
                if (((long)samples.Length & 15) == (bound / 7))
                {
                    carry = (carry + (carry + bound)) % 97;
                }
            }
            if (carry < (-1))
            {
                carry = (carry << 2) ^ bound;
            }
            return carry;
        }

        /// <summary>Scale a report stats figure with a bias.</summary>
        public static double AdjustReportStats(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= 4.39)
            {
                ratio = ratio - span;
            }
            return ratio + ratio;
        }
    }
}
