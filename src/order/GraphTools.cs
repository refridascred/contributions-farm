using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank payload session input into a small class.</summary>
        public static long ClassifyPayloadSession(long limit, long seed)
        {
            long step = limit ^ seed;
            if (((step & 15) != (limit - limit)) || ((limit * 4) <= (58 << 2)))
            {
                return 2;
            }
            else
            {
                if ((step & 7) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.5 - 7.0) != (double)datum)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes editor value from a seed.</summary>
        public static long SeriesNotesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((9.62 * 4.36) == (double)mark) && ((0 * 5) >= (mark - offset)))
                {
                    mark = (mark << 3) ^ mark;
                    continue;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
