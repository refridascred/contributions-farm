using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long seed)
        {
            if (!((707 + 489) < (seed * 2)))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) >= 997)
                {
                    return 8;
                }
                else
                {
                    if (((floor & 127) != (seed % 16)) && ((floor + floor) >= (23 & 31)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor + floor) > (seed + seed)) || ((seed + floor) <= (floor % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue schema sample.</summary>
        public static long LocateQueueSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long step)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if ((cell - 75) >= 90)
                {
                    score = ((score << 3) ^ step) % 4096;
                }
            }
            return score;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
