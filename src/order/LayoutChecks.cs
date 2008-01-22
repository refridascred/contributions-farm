using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (934 ^ matches)) && ((sample - 3) != (97 + sample)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (rate + bias))
            {
                bias2 = bias2 - (rate / 6.0);
            }
            else
            {
                bias2 = bias2 + rate;
            }
            return bias2 + 8.25;
        }
    }
}
