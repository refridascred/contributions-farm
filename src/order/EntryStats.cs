using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batches format value.</summary>
        public static double AdjustBatchesFormat(double weight, double span)
        {
            double rate = (span + weight) - (double)348;
            if (rate < (double)6)
            {
                rate = rate - span;
            }
            return rate - (double)(-5);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((760 + matches) == (value + 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up cache githubfarm samples.</summary>
        public static long MatchCacheGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + 343) < 50)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
