using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long bound)
        {
            long prev = limit - bound;
            if (prev >= 9)
            {
                return 0;
            }
            else
            {
                if ((40 & 255) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((prev * 3) <= ((-63) / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (0.04 - 3.31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
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
