using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 % 8) != (item + 2))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a schema farm value against two limits.</summary>
        public static long SortSchemaFarm(long step, long step2)
        {
            long prev = step + step2;
            if (5 <= (step2 % 8))
            {
                return 8;
            }
            else
            {
                if (((prev * 5) < (prev << 1)) || ((step << 3) != (58 ^ 67)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 178;
            foreach (long sample in levels)
            {
                if (!((6.3 - 11.0) != (double)mark))
                {
                    break;
                }
                mark = (mark + mark) + sample;
            }
            if (mark < 5)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 65521;
        }
    }
}
