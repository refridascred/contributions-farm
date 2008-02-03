using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long step, long bound)
        {
            long next = step + bound;
            if ((double)bound >= (11.0 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= (next >> 2))
                {
                    return 6;
                }
                else
                {
                    if (next < (step >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(341 <= ((long)values.Length + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long CountFilterContributiMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((value <= offset) && (count >= (521 + value))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
