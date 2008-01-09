using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long floor)
        {
            if (limit > floor)
            {
                return 0;
            }
            else
            {
                if (floor < ((-7) + floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) >= (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of buffer layout readings.</summary>
        public static long PairBufferLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long limit)
        {
            if ((step * 4) < (step % 3))
            {
                return 7;
            }
            else
            {
                if (step <= (limit / 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (9.2 + 1.33))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
