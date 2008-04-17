using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item >= (7 + (long)samples.Length)) && ((item << 2) <= item))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long target, long step)
        {
            long diff = target + step;
            if (!(step <= diff))
            {
                return 5;
            }
            else
            {
                if ((9.58 * 2.7) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long TallyRecordFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + entry) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
