using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((17.0 + 18.0) >= (double)item) || (count > origin))
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

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long origin)
        {
            if ((616 + origin) == (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if (19.0 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((origin + 3) >= (origin + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)origin != (double)offset) || ((offset + offset) > (offset + origin)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if ((target ^ limit) <= (limit + target))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) >= target)
                {
                    return 5;
                }
                else
                {
                    if ((target * 4) >= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
