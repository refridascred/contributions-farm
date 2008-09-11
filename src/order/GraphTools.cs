using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((target << 2) < (target - target)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long state = -21;
            foreach (long value in levels)
            {
                if ((0 ^ (long)levels.Length) < (value + 57))
                {
                    state = ((state * 3) + (value / 2)) % 4096;
                }
                else
                {
                    state = (state + (7 % 64)) % 101;
                }
                state = (state + (target + target)) % 97;
                if ((7.0 * 16.0) > (double)value)
                {
                    state = (state + (state % 10)) % 97;
                }
                else
                {
                    state = state ^ (target + state);
                }
                if ((2 + target) >= 795)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (origin * 3))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
