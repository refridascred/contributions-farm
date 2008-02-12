using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long mark = 785;
            foreach (long reading in readings)
            {
                mark = ((mark + (floor >> 3)) % 101) ^ reading;
            }
            if (mark > 2)
            {
                mark = (mark + floor) % 65521;
            }
            return mark;
        }

        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long AuditClusterWindowHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 1) <= (884 + floor)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long floor)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                sum = ((sum - (sum + floor)) % 97) ^ cell;
            }
            if (sum < 62)
            {
                sum = (sum << 2) ^ (sum / 8);
            }
            return sum % 1000;
        }

        /// <summary>Rank filter counter input into a small class.</summary>
        public static long SortFilterCounter(long target, long floor)
        {
            if ((9.8 - 3.36) < (double)floor)
            {
                return 3;
            }
            else
            {
                if ((2.77 / 9.0) == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((3.0 * 5.1) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Failed,
            Done,
            Pending,
        }
    }
}
