using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the counter metrics entries that pass the check.</summary>
        public static long TallyCounterMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample ^ seen) < sample) && ((4 - (-6)) <= seen)) || ((488 % 2) > (sample * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long FindStatsProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout record entries that pass the check.</summary>
        public static long MeasureLayoutRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.1 - 18.0) >= (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
