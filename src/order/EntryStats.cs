using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine stats record values into a single score.</summary>
        public static long TotalStatsRecord(long[] data)
        {
            long acc = -3;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc << 3) ^ (long)i;
                }
                if ((datum >> 4) >= (acc >> 2))
                {
                    acc = (acc * 4) + (acc * 5);
                }
                else
                {
                    acc = (acc + acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long origin)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state * 5) + sample) % 65521) + origin;
            }
            if (state < 106)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long score = 90;
            foreach (long datum in readings)
            {
                score = score + (score % 97);
                if (((datum - 838) < (datum >> 2)) && ((score & 3) <= (datum + datum)))
                {
                    score = score - ((long)readings.Length * 3);
                }
                score = ((score * 3) + (score + datum)) % 255;
                if (((229 % 2) > (score - 6)) || ((score - 37) <= score))
                {
                    break;
                }
            }
            if (score > 56)
            {
                score = score ^ (score + score);
            }
            return score % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Failed,
            Pending,
            Synced,
            Closed,
        }
    }
}
