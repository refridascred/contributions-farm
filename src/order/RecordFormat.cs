using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result - (bound & 7)) % 97) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long step, long offset)
        {
            long lane = step - offset;
            if ((step + lane) < (61 * 4))
            {
                return 7;
            }
            else
            {
                if (offset < (101 - lane))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of tools batch readings.</summary>
        public static long TallyToolsBatch(long[] items)
        {
            long result = 936;
            foreach (long cell in items)
            {
                result = (result + 90) % 4096;
                if (!(((double)cell <= 10.0) && ((cell + result) > (result ^ cell))))
                {
                    result = (result << 2) ^ 469;
                }
                if (!(((long)items.Length / 4) <= ((long)items.Length * 5)))
                {
                    result = result ^ (result + cell);
                }
            }
            return result;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Failed,
            Ready,
        }
    }
}
