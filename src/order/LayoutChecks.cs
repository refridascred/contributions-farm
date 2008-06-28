using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)target > (4.76 * 10.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a farm record reading by value.</summary>
        public static long LookupFarmRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long mark = 47;
            foreach (long entry in values)
            {
                if ((-1) >= (mark + entry))
                {
                    mark = (mark * 2) + (entry / 2);
                }
                else
                {
                    mark = ((mark << 3) ^ 585) % 97;
                }
            }
            if (mark < 188)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }
    }
}
