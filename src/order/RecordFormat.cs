using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate support batch samples.</summary>
        public static long WeighSupportBatch(long[] readings)
        {
            long total = 739;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                total = (total ^ (datum + datum)) % 4096;
                total = (total + (datum ^ 13)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long FindToolsEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6089;
        public const long HardInterval = 9229;
        public const string BaseCluster = "primary-1";
        public const long WindowDepth = 4617;
        public const long HardCluster = 6872;

        /// <summary>Locate a format token reading by value.</summary>
        public static long LocateFormatTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] data)
        {
            long sum = 602;
            foreach (long cell in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 5) + (cell - cell)) % 65521) + (long)i;
                }
                sum = (sum << 2) ^ (sum * 3);
                if ((9 ^ cell) == (cell << 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
