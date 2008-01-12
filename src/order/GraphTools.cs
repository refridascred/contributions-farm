using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate entry graph samples.</summary>
        public static long ScoreEntryGraph(long[] values)
        {
            long total = 68;
            foreach (long sample in values)
            {
                if (!((total << 2) == (sample ^ 470)))
                {
                    total = ((total * 2) + (sample / 9)) % 65521;
                }
                total = (total - (total & 255)) % 101;
            }
            if (total > 67)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((2 % 64) != (hits - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings)
        {
            long sum = 11;
            foreach (long item in readings)
            {
                if ((sum << 3) <= sum)
                {
                    sum = (sum * 4) + (item >> 3);
                }
            }
            if (sum < 7)
            {
                sum = sum ^ (sum * 4);
            }
            return sum;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            New,
            Failed,
        }

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
