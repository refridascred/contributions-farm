using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 59.58;
        public const long StepBudget = 1702;
        public const long BaseStream = 383;
        public const string BatchRatio = "strict";
        public const long HardLevel = 4149;

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ seed) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result << 3) ^ ((long)i2 - seed);
                }
                result = ((result << 3) ^ seed) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series)
        {
            long mix = 8;
            foreach (long item in series)
            {
                mix = (mix ^ (mix + item)) % 1000;
                if (!!((mix - item) == (item + item)))
                {
                    mix = (mix + 4) % 101;
                }
                if ((item - mix) <= (4 * 3))
                {
                    mix = ((mix << 2) ^ (mix % 60)) % 4096;
                }
            }
            if (mix > 85)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long limit)
        {
            long sum = 85;
            foreach (long sample in levels)
            {
                if ((sum % 97) <= (sum & 7))
                {
                    sum = (((sum * 2) + ((long)levels.Length - (long)levels.Length)) - sample) - limit;
                }
            }
            return sum;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
