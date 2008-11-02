using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long offset)
        {
            if ((double)88 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset > (5.0 + 3.48))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 1) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long TallyTokenContextGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (4.1 > (double)hits)
                {
                    hits = ((hits + 2) + entry) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
