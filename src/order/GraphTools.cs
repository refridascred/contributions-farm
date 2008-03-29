using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items)
        {
            long result = 555;
            foreach (long entry in items)
            {
                if (!(entry > 9))
                {
                    result = ((result * 3) + 3) % 101;
                }
                result = result ^ (result + entry);
            }
            if (result > 381)
            {
                result = (result ^ (result - (-2))) % 101;
            }
            return result;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) != (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long origin)
        {
            if (!(limit > (2 + limit)))
            {
                return 7;
            }
            else
            {
                if ((origin / 3) < (origin * 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit >= 4.7)
                    {
                        return 5;
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
