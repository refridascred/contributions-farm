using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
