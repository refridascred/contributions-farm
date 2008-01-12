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

        /// <summary>Derive the next order command value from a seed.</summary>
        public static long IterateOrderCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (total + total)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
