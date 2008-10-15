using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((datum + seen) <= datum) && ((0.54 * 5.26) != (double)origin)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format tools values into a single score.</summary>
        public static long ScoreFormatTools(long[] data)
        {
            long anchor = 144;
            foreach (long datum in data)
            {
                if (!((anchor + anchor) <= (datum + anchor)))
                {
                    anchor = (anchor + (datum ^ anchor)) % 4096;
                }
                if (((datum / 7) >= (anchor ^ datum)) || ((datum + datum) != (datum ^ anchor)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
