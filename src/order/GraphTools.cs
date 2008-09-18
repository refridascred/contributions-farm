using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Stale,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Scale a profile metric figure with a bias.</summary>
        public static double ProjectProfileMetric(double bias, double floor)
        {
            double weight = (bias - 7.3) * 8.36;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)192) + (double)(long)i) + floor;
            }
            return weight + weight;
        }

        /// <summary>Derive the next checks account value from a seed.</summary>
        public static long DeriveChecksAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
