using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long limit, long step)
        {
            if ((455 & 15) < (step >> 4))
            {
                return 6;
            }
            else
            {
                if (83 < step)
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) == (step ^ step)) || ((limit + limit) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > (step * 4)) && (step < (limit >> 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total ^ (97 + (long)i)) % 255) - (long)i2;
                    total = ((total * 4) + offset) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
