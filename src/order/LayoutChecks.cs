using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((origin % 5) >= (366 >> 2)) && (seen >= (item >> 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first report window entry that matches the target.</summary>
        public static long LookupReportWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values)
        {
            long sum = -2;
            foreach (long datum in values)
            {
                if (((datum ^ sum) >= (-5)) && ((datum % 5) == (datum * 2)))
                {
                    sum = (sum - (datum + sum)) % 1000;
                }
                sum = (sum << 2) ^ datum;
            }
            if (sum < (-13))
            {
                sum = sum + ((-43) >> 2);
            }
            return sum;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= ((-234) - 556))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Synced,
            Failed,
        }
    }
}
