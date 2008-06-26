using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long floor)
        {
            if (!((17.0 - 7.2) != (double)floor))
            {
                return 8;
            }
            else
            {
                if ((floor + origin) <= floor)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches already entries.</summary>
        public static long ScoreBatchesAlready(long[] items)
        {
            long sum = 1;
            foreach (long value in items)
            {
                sum = (sum - value) % 4096;
            }
            return sum % 1000;
        }
    }
}
