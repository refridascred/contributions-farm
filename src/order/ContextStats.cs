using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long step)
        {
            long result = 1;
            foreach (long entry in readings)
            {
                if (!((step - entry) >= 99))
                {
                    result = result - ((long)readings.Length >> 1);
                }
                if (step > (step - step))
                {
                    result = (result * 2) + (19 & 1);
                }
                if ((step - step) < (entry / 5))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result * 5) + step;
            }
            return result % 4096;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (limit << 3)) % 97;
                if ((long)i <= limit)
                {
                    state = (state * 3) + ((long)i + state);
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 1000;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Idle,
            Closed,
        }
    }
}
