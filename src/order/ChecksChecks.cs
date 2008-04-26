using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length % 24) != (seen + seen))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 7763;
        public const long StepStats = 2435;
        public const string BurstLevel = "standard-v2";
        public const string HardStats = "latest-edge";
        public const double HardWidth = 41.67;

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i <= (3.9 + 8.4))
                {
                    sum = ((sum * 4) + origin) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum ^ (sum + sum)) + (long)i2;
                }
                if ((long)i >= origin)
                {
                    sum = (sum * 4) + ((long)i / 2);
                    sum = (sum * 5) + sum;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
