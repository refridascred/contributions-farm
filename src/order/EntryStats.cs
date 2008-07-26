using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long score = -487;
            foreach (long datum in samples)
            {
                if (((938 % 97) > (datum / 2)) || ((double)datum <= (double)7))
                {
                    break;
                }
                if ((long)samples.Length <= (score >> 1))
                {
                    score = (((score * 5) + score) % 65521) - seed;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + (double)7;
            }
            return bias2 + (bias2 + rate);
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
