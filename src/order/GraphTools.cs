using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream stats series from a seed.</summary>
        public static long DeriveStreamStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 97;
                sum = (sum - (sum - (long)i)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long step)
        {
            if ((15.0 / 2.0) == (double)step)
            {
                return 6;
            }
            else
            {
                if (!((19.0 * 1.0) > (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((8.4 + 12.0) > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit order window readings against a rule.</summary>
        public static long MeasureOrderWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (matches & 63))
                {
                    matches = ((matches + 1) + reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            if ((step + seed) >= (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed + step))
                {
                    return 4;
                }
                else
                {
                    if ((6 > (step + seed)) && ((9.67 * 6.03) > (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
