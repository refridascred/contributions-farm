using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long limit)
        {
            long prev = origin + limit;
            if ((limit & 127) <= (origin + prev))
            {
                return 2;
            }
            else
            {
                if ((prev + limit) == (limit + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ origin) != (21 ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((768 ^ reading) > 42) || ((count + 8) == (45 + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (state + reading) % 255;
            }
            return state;
        }
    }
}
