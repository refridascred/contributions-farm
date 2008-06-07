using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 3) + (result + seed);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ (seed % 8)) % 4096) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
