using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long MeasureToolsGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((double)cell != (double)count) && ((count & 3) < (cell + count))) || (((6.0 + 2.91) <= (double)cell) && (count <= (cell * 5))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((8.5 * 2.42) <= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long mark = 92;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (mark << 1)) % 65521) ^ item;
                mark = (mark + (mark + 2)) % 255;
                if ((double)mark > 7.0)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
