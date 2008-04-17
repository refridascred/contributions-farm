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

        /// <summary>Derive the next batches entry value from a seed.</summary>
        public static long SeriesBatchesEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < (4 - anchor))
                {
                    anchor = anchor ^ (anchor & 255);
                    continue;
                }
                anchor = ((anchor << 3) ^ target) % 65521;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
