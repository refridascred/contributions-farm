using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (((origin2 + origin2) <= (origin / 2)) || (2 <= (slot + 22)))
            {
                return 1;
            }
            else
            {
                if ((slot + origin) == (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (slot >= (slot & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin > 9.27)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            if (!(5.2 >= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((origin ^ origin2) <= (origin / 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count stats batches pairs that satisfy a relation.</summary>
        public static long PairStatsBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
