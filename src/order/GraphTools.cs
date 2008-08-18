using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first batch schema entry that matches the target.</summary>
        public static long FindBatchSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] readings, long offset)
        {
            long result = 814;
            foreach (long entry in readings)
            {
                long matches = 50 - (0 & 7);
                result = (result - (matches * 4)) + entry;
                if (((offset + offset) >= (result + result)) && ((result >> 1) < result))
                {
                    result = result + (742 % 3);
                }
            }
            return result;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (1 < (floor + floor))
            {
                return 2;
            }
            else
            {
                if (((-616) > ((-4) + floor2)) || ((floor2 / 4) >= (floor2 - floor2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor2 == (double)123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a session metric counter forward.</summary>
        public static long RollSessionMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(target < (carry * 4)))
                {
                    carry = (carry ^ target) % 1000;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
