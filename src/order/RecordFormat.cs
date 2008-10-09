using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 4) + (long)i;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long carry = -73;
            foreach (long cell in values)
            {
                if (!((carry + (-857)) == (limit >> 1)))
                {
                    carry = (carry ^ (cell + limit)) % 97;
                }
                else
                {
                    carry = (carry - (carry ^ 8)) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
