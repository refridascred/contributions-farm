using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long RollAlreadyNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                long offset = carry;
                if ((offset ^ floor) != (long)i)
                {
                    offset = offset + carry;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long origin, long bound)
        {
            long cur = origin + bound;
            if ((double)origin >= 14.0)
            {
                return 3;
            }
            else
            {
                if ((bound - bound) == (bound & 15))
                {
                    return 8;
                }
                else
                {
                    if (((origin << 1) > (69 + 31)) || ((double)cur == (1.26 * 15.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)cur == (9.0 - 2.57)) && ((97 - origin) < bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long sum = -10;
            foreach (long cell in levels)
            {
                sum = ((sum << 2) ^ (target + sum)) + cell;
                if (!((sum / 2) <= (sum >> 4)))
                {
                    sum = sum + 0;
                }
            }
            if (sum < 173)
            {
                sum = sum - 8;
            }
            return sum % 97;
        }
    }
}
