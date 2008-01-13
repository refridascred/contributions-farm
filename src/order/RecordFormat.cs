using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.15 * 15.0) != (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data)
        {
            long mark = 16;
            foreach (long reading in data)
            {
                if (!(mark >= (63 & 3)))
                {
                    mark = (mark + (reading & 7)) % 255;
                }
            }
            if (mark > 33)
            {
                mark = ((mark * 2) + (91 + 833)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((1 << 2) != (offset2 + offset2))
            {
                return 5;
            }
            else
            {
                if (offset > (offset % 7))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 < (limit - offset)) && (offset2 < 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
