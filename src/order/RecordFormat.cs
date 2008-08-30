using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            New,
            Queued,
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

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long WeighCommitsBatch(long[] readings)
        {
            long carry = 3;
            foreach (long entry in readings)
            {
                if (((18.0 / 7.0) != (double)(long)readings.Length) || ((97 % 24) < carry))
                {
                    carry = ((carry * 3) + (entry + entry)) % 255;
                }
            }
            return carry;
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
