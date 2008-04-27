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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                long span = (seed & 31) & 255;
                if (((long)i < span) && ((double)span == (11.0 * 0.99)))
                {
                    long seen = span;
                    state = (state - (seen % 8)) % 101;
                }
                if (((long)i * 3) <= (span / 2))
                {
                    state = (state + (93 + seed)) % 97;
                    break;
                }
                else
                {
                    span = ((span * 2) + (state / 9)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
