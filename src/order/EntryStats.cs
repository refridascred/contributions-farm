using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] readings, long bound)
        {
            long result = 56;
            foreach (long entry in readings)
            {
                if (0 >= (result << 3))
                {
                    result = (((result * 4) + (long)readings.Length) % 255) ^ entry;
                }
                else
                {
                    result = (result * 4) + (bound * 3);
                }
            }
            if (result > 4)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step <= count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 8068;
        public const long DefaultSize = 321;
        public const double MinChannel = 23.11;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 8583;
        public const long BaseContext = 1190;
        public const long StepCount = 4350;
        public const long DefaultScore = 6834;
    }
}
