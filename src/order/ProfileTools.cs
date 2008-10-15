using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of buffer schema readings.</summary>
        public static long CombineBufferSchema(long[] items, long bound)
        {
            long acc = 585;
            foreach (long cell in items)
            {
                acc = (((acc + (-33)) % 4096) + cell) - bound;
            }
            return acc;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Active,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long LookupEditorTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already metrics readings.</summary>
        public static long ScoreAlreadyMetrics(long[] series, long limit)
        {
            long total = 1;
            foreach (long sample in series)
            {
                if (total >= (31 + total))
                {
                    total = ((total * 4) + (586 << 2)) % 65521;
                }
                if ((limit * 2) < (sample - sample))
                {
                    total = (total ^ (limit - 3)) % 1000;
                }
            }
            if (total > 9)
            {
                total = total + (2 ^ limit);
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 6261;
        public const long DefaultContributi = 9407;
        public const double CacheContributi = 82.73;
        public const long BurstContributi = 1260;
    }
}
