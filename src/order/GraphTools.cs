using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long result = -948;
            foreach (long datum in levels)
            {
                if ((datum * 2) >= (result & 3))
                {
                    result = ((result << 2) ^ (result - 38)) % 255;
                }
                else
                {
                    result = (result ^ ((-13) & 31)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double ratio = 9.6;
            if (ratio >= (double)16)
            {
                ratio = (ratio + offset) - scale;
            }
            else
            {
                ratio = ratio + 1.7;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 1752;
        public const double MinTimeout = 70.39;
        public const double BatchTimeout = 46.27;
        public const long LimitTools = 9572;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2820;
        public const long BaseCommand = 3986;
        public const long RetryCount = 8149;
        public const long HardCommand = 1902;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result - (seed / 5)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result * 4) + (long)i2) % 97;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
