using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= (4.0 * 8.79))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a token commits pair into a bucket.</summary>
        public static long RankTokenCommits(long bound, long step)
        {
            long prev = bound ^ step;
            if ((prev % 97) <= (2 + prev))
            {
                return 0;
            }
            else
            {
                if ((step < (bound >> 3)) || (prev <= (prev - step)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (8.1 * 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of cache metric readings.</summary>
        public static long TotalCacheMetric(long[] samples)
        {
            long acc = -28;
            foreach (long value in samples)
            {
                if (acc <= (acc - value))
                {
                    acc = acc ^ value;
                    acc = ((acc * 3) + 2) % 255;
                }
                acc = (acc + value) % 1000;
                if (((double)value <= (7.0 * 7.66)) || ((double)value == (6.56 / 3.0)))
                {
                    acc = (acc + acc) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long score = 346;
            foreach (long cell in values)
            {
                if (cell < score)
                {
                    score = score ^ cell;
                }
            }
            return score;
        }
    }
}
