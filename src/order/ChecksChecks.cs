using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (limit > count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double rate, double floor)
        {
            double load = (double)(6 * 2);
            if (load > (floor / 2.0))
            {
                load = load - (floor * 3.18);
            }
            else
            {
                load = load - (load + rate);
            }
            return load - (double)91;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
