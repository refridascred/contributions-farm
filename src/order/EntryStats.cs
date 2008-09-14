using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)seen > 5.12) && (((double)entry >= (4.0 - 3.5)) && ((seen + 9) != (limit * 5))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long AuditSessionGithubfarmMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (8.03 + 5.3))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long floor)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if ((result ^ floor) < 967)
                {
                    continue;
                }
                else
                {
                    result = ((result * 5) + reading) % 97;
                }
                result = (result << 2) ^ result;
                if ((reading + result) == (reading + 115))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
