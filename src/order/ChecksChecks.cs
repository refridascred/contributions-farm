using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (origin <= (9 + floor))
            {
                return 5;
            }
            else
            {
                if (!((double)floor == (double)85))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long origin)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                acc = (acc - (entry / 9)) % 65521;
                if ((6.88 + 6.01) > (double)acc)
                {
                    acc = acc ^ (origin * 2);
                }
            }
            if (acc > (-8))
            {
                acc = acc + ((-720) / 7);
            }
            return acc;
        }
    }
}
