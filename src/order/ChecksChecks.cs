using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell / 5) == (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 9;
            foreach (long value in values)
            {
                if (!((sum + value) != (4 % 8)))
                {
                    sum = sum ^ (4 << 2);
                }
                if ((((-353) % 12) > value) && (value <= (sum >> 4)))
                {
                    sum = ((sum << 3) ^ (93 / 2)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (sum % 16);
                }
            }
            if (sum < 360)
            {
                sum = (sum - (7 / 3)) % 101;
            }
            return sum;
        }
    }
}
