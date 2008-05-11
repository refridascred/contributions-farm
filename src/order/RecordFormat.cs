using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long seed)
        {
            long sum = 611;
            foreach (long item in readings)
            {
                if ((double)89 <= (double)seed)
                {
                    sum = (sum + (item ^ item)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 7) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = -153;
            foreach (long entry in samples)
            {
                result = ((result << 2) ^ 8) % 4096;
                if ((4.0 - 9.0) < (double)entry)
                {
                    result = result ^ (entry - entry);
                }
            }
            return result;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            if (6 > (bound ^ limit))
            {
                return 2;
            }
            else
            {
                if ((2.31 - 6.0) >= 5.36)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
