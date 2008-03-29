using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                if (0 > (step + (long)i))
                {
                    acc = ((acc * 2) + (step + step)) % 4096;
                }
                else
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)floor <= (4.82 / 4.0))
                {
                    score = (score - (floor % 64)) % 65521;
                }
                else
                {
                    score = (score ^ (score + 9)) % 4096;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long target)
        {
            long offset = floor ^ target;
            if (!((target + floor) <= (target >> 1)))
            {
                return 3;
            }
            else
            {
                if (((target << 3) == (2 + floor)) || (6.6 <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((6.0 - 5.1) >= (double)floor) || (1.67 >= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + target) <= 2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
