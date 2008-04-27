using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Done,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark * 5) + (340 << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long limit)
        {
            if ((origin - origin) == (2 + origin))
            {
                return 1;
            }
            else
            {
                if ((limit ^ origin) < (origin - (-4)))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 3) < 66) && (origin < (origin ^ origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) != (item - (long)data.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
