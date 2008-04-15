using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            if ((target <= (bound * 2)) && ((7.1 * 7.21) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((bound * 5) <= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ 6) < target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10.0 + 9.36) < (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((4.56 < (double)seed) || ((double)state == (4.0 / 8.0)))
                {
                    state = state ^ state;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - 516) <= (count >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first channel filter entry that matches the target.</summary>
        public static long SeekChannelFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
