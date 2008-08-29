using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Pending,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 60) > (845 << 3))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score - (score & 1)) % 4096;
                score = (score << 2) ^ (bound - score);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
