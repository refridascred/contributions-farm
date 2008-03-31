using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - (target / 6);
                if ((target - target) != ((long)i + sum))
                {
                    sum = (sum + sum) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data, long floor)
        {
            long sum = 40;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (value << 2)) + floor;
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
