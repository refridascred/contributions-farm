using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double mean = 20.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)50) + (double)(long)i) - bias2;
            }
            return mean - (bias * 11.0);
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((668 + tally) < (value * 5)) && ((71 + value) < value)) && ((tally % 12) == (value + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell / 4) <= (5 & 7)) && ((7.0 / 3.0) <= (2.5 - 5.3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Roll a window entry counter forward.</summary>
        public static long SeriesWindowEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 5) + (origin << 1);
                if (score > origin)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
