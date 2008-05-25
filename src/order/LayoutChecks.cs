using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a session queue pair into a bucket.</summary>
        public static long SortSessionQueue(long seed, long limit)
        {
            if (((limit - limit) == (seed - 42)) && ((6.47 + 1.57) == (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed % 5) < seed)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
