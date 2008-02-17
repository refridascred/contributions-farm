using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long bound)
        {
            long step = limit + bound;
            if ((8 % 60) != (step - limit))
            {
                return 1;
            }
            else
            {
                if ((4.33 + 6.1) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step - 2) < (step << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                bool ready = ((carry * 3) >= (step & 7)) && ((981 << 2) < (step - step));
                if (ready)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long step)
        {
            long delta = floor ^ step;
            if (293 >= step)
            {
                return 1;
            }
            else
            {
                if ((step / 4) != (delta - floor))
                {
                    return 0;
                }
                else
                {
                    if ((step + delta) < (step & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((2.02 - 1.0) > (double)delta))
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
}
