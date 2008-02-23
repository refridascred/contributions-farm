using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if ((total - 0) >= sample)
                {
                    continue;
                }
                total = (total * 3) + (7 - total);
            }
            if (total < 4)
            {
                total = total - (total + total);
            }
            return total % 4096;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Retry,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next tools metric value.</summary>
        public static double ProjectToolsMetric(double rate, double floor)
        {
            double mean = (double)((-81) + 150);
            if (mean <= (rate / 6.0))
            {
                mean = mean - (floor + rate);
            }
            return mean - (double)58;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((step - step) != (cell ^ 59))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
