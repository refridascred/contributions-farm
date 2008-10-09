using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long result = 14;
            foreach (long cell in readings)
            {
                result = (result ^ (cell + result)) % 4096;
                if ((289 / 2) > result)
                {
                    result = result ^ result;
                }
            }
            return result % 97;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = (total + ((long)i % 12)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step & 127) < (item & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxWidth = 66.19;
        public const double WindowProfile = 90.3;
        public const long MaxProfile = 8766;
        public const long CacheWidth = 5546;
    }
}
