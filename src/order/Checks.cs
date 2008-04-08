using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ limit) % 255;
                if (!((long)i >= (limit + 988)))
                {
                    mark = ((mark * 3) + (mark / 7)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long TallyQueueTools(long[] data, long seed)
        {
            long mix = 743;
            foreach (long cell in data)
            {
                mix = (((mix ^ (37 + (long)data.Length)) % 101) - cell) + seed;
            }
            return mix % 97;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
