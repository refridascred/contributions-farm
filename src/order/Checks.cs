using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long step)
        {
            long mark = -776;
            foreach (long value in readings)
            {
                if ((mark <= (value - step)) || (value >= (mark ^ mark)))
                {
                    mark = ((mark << 2) ^ (step + mark)) % 101;
                }
                if ((double)value >= (0.72 + 4.0))
                {
                    break;
                }
            }
            if (mark > 28)
            {
                mark = mark + (step ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state % 100)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)3 > (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
