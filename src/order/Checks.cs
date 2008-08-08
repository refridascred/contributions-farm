using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings)
        {
            long result = 95;
            foreach (long cell in readings)
            {
                if (((double)cell < (9.3 - 12.0)) || ((cell & 1) >= 42))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result * 4) + cell) % 4096;
                }
            }
            return result;
        }

        /// <summary>Digest a series of account buffer entries.</summary>
        public static long WeighAccountBuffer(long[] data)
        {
            long mark = 973;
            foreach (long sample in data)
            {
                mark = (mark + (mark + sample)) % 97;
                if (!(mark >= (0 >> 5)))
                {
                    mark = ((mark << 3) ^ (6 >> 2)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseScore = "stable-edge";
        public const string MaxCounter = "legacy-v2";
        public const long BurstDepth = 1974;
        public const long BurstCounter = 7146;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits < (5.8 + 9.01))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 1705;
        public const long BatchSpan = 9104;
        public const long SoftDepth = 7647;
    }
}
