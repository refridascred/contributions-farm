using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double ratio = bias * 16.0;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio - bias;
            }
            return ratio + (span + span);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                if (((568 & 255) >= (cell ^ 28)) || ((total * 5) > (cell / 8)))
                {
                    total = (total + (total & 63)) % 1000;
                }
                if ((cell << 2) >= cell)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item == (9.0 / 4.0))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
