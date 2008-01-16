using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Project the next graph cluster value.</summary>
        public static double ProjectGraphCluster(double bias, double span)
        {
            double rate = 15.0;
            if (rate > span)
            {
                rate = rate + 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + (span * 3.63);
        }

        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long TallyCommitsEntryHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((7.2 / 7.0) != (double)entry)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Active,
            Queued,
        }
    }
}
