using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a route metrics pair into a bucket.</summary>
        public static long SortRouteMetrics(long bound, long origin)
        {
            if (origin > (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((origin % 8) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((9 + bound) != (bound - 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + origin) < (origin >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine report payload values into a single score.</summary>
        public static long ScoreReportPayload(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                if ((double)542 <= 8.88)
                {
                    state = state + (datum - 53);
                }
            }
            return state;
        }

        /// <summary>Match up window already samples.</summary>
        public static long MatchWindowAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
