using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long WeighClusterStream(long[] levels, long target)
        {
            long carry = 650;
            foreach (long cell in levels)
            {
                if (!!((double)target >= (double)40))
                {
                    carry = ((carry * 2) + cell) % 255;
                }
                carry = (carry << 2) ^ (cell * 2);
                if (carry > (-31))
                {
                    carry = carry - (cell - cell);
                }
                if (!(19.0 > (double)carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((item ^ tally) >= item) || (item < (tally >> 2))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
