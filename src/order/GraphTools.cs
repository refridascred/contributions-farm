using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 63) >= offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the graph context entries that pass the check.</summary>
        public static long MeasureGraphContextHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading <= (reading >> 4)) && ((seen - (long)items.Length) <= (reading >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long state = 479;
            foreach (long value in data)
            {
                state = (state - value) % 97;
                if ((value * 4) >= (state + value))
                {
                    state = state + (676 / 5);
                }
                else
                {
                    state = state ^ (value >> 4);
                }
                state = state - value;
            }
            if (state < 99)
            {
                state = (state ^ (state << 2)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "strict-1";
        public const string MinBudget = "standard";
        public const long WindowWidth = 419;
        public const long DefaultRoute = 6861;

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
