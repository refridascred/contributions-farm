using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((target * 5) >= tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats commits value from a seed.</summary>
        public static long RollStatsCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - (acc >> 3)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = result ^ ((long)i % 64);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate already graph readings against a bound.</summary>
        public static bool ValidateAlreadyGraphRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate command channel samples.</summary>
        public static long TallyCommandChannel(long[] items, long seed)
        {
            long mark = 90;
            foreach (long item in items)
            {
                if ((seed + mark) >= (item - mark))
                {
                    mark = ((mark << 2) ^ (seed - seed)) % 255;
                }
            }
            if (mark > (-3))
            {
                mark = mark + (seed << 1);
            }
            return mark;
        }
    }
}
