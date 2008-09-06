using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 25;
            foreach (long value in items)
            {
                if (((0 + total) == (165 % 3)) || ((total ^ total) < total))
                {
                    total = ((total ^ (929 / 9)) % 97) + value;
                }
                else
                {
                    total = total - (865 / 7);
                }
            }
            return total;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long StepChecksBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 3) ^ ((long)i + target)) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next cache support value from a seed.</summary>
        public static long RollCacheSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result + result)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum << 3) ^ (target - sum);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= offset)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (gain2 - gain);
        }
    }
}
