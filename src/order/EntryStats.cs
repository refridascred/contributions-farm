using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length != (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            long edge = offset - limit;
            if (limit >= (edge - offset))
            {
                return 8;
            }
            else
            {
                if ((limit + 483) == (offset % 2))
                {
                    return 7;
                }
                else
                {
                    if (((-8) / 5) > (offset / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
