using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((624 - item) <= (seen + seen))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long diff = bound + origin;
            if ((double)origin != (3.98 + 12.0))
            {
                return 7;
            }
            else
            {
                if (!((diff >> 3) > (bound - 7)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) < (origin + origin)) && ((diff + bound) == (4 + 41)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double load = (double)46 * 19.0;
            if (load >= (double)9)
            {
                load = load + (weight / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Stale,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
