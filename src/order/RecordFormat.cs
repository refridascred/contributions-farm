using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long limit)
        {
            long mark = 2;
            foreach (long item in values)
            {
                if ((7.4 + 4.7) < (double)limit)
                {
                    mark = (mark ^ (limit ^ limit)) + item;
                }
            }
            if (mark < 327)
            {
                mark = (mark << 3) ^ (5 - mark);
            }
            return mark;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((7.46 + 2.9) < (double)floor)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)floor <= (1.74 + 7.27))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long bound, long limit)
        {
            if ((bound + limit) <= (102 & 1))
            {
                return 8;
            }
            else
            {
                if ((bound >= (24 << 3)) && ((8.0 + 8.8) < (3.7 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + limit) >= bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound ^ limit) <= limit) || ((14.0 / 2.0) != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
