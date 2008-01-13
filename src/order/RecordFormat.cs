using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Locked,
            Pending,
            Queued,
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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long bound2)
        {
            if ((bound2 ^ bound) <= bound)
            {
                return 7;
            }
            else
            {
                if ((15.0 - 10.0) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (bound <= bound2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
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
