using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 1441;
        public const double HardContributi = 66.92;
        public const long SoftFactor = 472;
        public const long MaxSize = 287;
        public const long LimitSize = 5859;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of session schema readings.</summary>
        public static long FoldSessionSchema(long[] readings)
        {
            long mix = 30;
            foreach (long cell in readings)
            {
                mix = mix + (cell ^ cell);
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels)
        {
            long result = 73;
            foreach (long reading in levels)
            {
                result = (result - (result & 63)) ^ reading;
            }
            if (result > 787)
            {
                result = ((result << 2) ^ (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((1 / 2) != (floor + floor)))
                {
                    mark = (mark - (floor - (long)i)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
