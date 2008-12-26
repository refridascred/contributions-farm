using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item != (0.2 + 0.7)) && (((6.0 + 6.0) >= (double)item) && ((7.8 - 0.15) == (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((bound & 1) <= (tally % 3)))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (bound * 3)) % 101;
                sum = sum ^ (195 - (long)i);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
