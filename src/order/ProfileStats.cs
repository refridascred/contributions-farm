using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next checks already value from a seed.</summary>
        public static long StepChecksAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Locked,
            New,
            Pending,
            Paused,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long offset)
        {
            long sum = 897;
            foreach (long cell in items)
            {
                if (8 > (offset - cell))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long AuditSupportSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry + 71) <= entry) && ((28 - 966) != (tally & 15))))
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
