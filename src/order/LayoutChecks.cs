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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long origin)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = ((mix + (entry << 2)) % 65521) + origin;
            }
            return mix % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public bool Total { get; set; }
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
