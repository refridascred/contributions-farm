using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark - mark) - (long)i;
                    mark = mark ^ ((-604) - value);
                }
                mark = (mark << 3) ^ (value ^ mark);
                if (((mark + mark) < ((long)values.Length + value)) || (mark > (mark & 7)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + 5) <= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 31;
            foreach (long value in samples)
            {
                if (581 >= (mark * 3))
                {
                    mark = (mark << 2) ^ (331 ^ (-7));
                }
                if ((double)mark < (0.88 / 9.0))
                {
                    break;
                }
                if (((9 + mark) > (value ^ mark)) || ((value ^ mark) >= (mark + value)))
                {
                    mark = (mark + (value - value)) % 101;
                }
            }
            return mark;
        }
    }
}
