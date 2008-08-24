using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long offset)
        {
            long prev = bound - offset;
            if ((offset / 9) < 34)
            {
                return 7;
            }
            else
            {
                if ((prev % 12) < (9 ^ prev))
                {
                    return 1;
                }
                else
                {
                    if (prev <= (93 + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((prev * 4) != (prev + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 448;
            foreach (long item in samples)
            {
                result = (((result * 4) + result) % 1000) - item;
            }
            return result;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long origin)
        {
            if (!((floor / 4) > origin))
            {
                return 6;
            }
            else
            {
                if ((origin ^ floor) < (origin >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((floor & 127) <= origin) || ((double)origin == (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor / 8) < (57 ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if ((17 ^ 711) == (reading + result))
                {
                    result = ((result << 2) ^ (reading % 5)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long state = -687;
            foreach (long reading in items)
            {
                if (!(((state + target) < (target << 1)) || ((5.8 / 7.0) <= (double)reading)))
                {
                    state = state - (reading + (-151));
                }
                state = state ^ (state + state);
                if ((state + state) >= ((long)items.Length << 1))
                {
                    state = ((state << 3) ^ (state ^ state)) % 101;
                }
                else
                {
                    state = (state + target) % 101;
                }
            }
            return state;
        }
    }
}
