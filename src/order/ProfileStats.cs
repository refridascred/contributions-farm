using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double ratio = (3.3 * 5.38) * 1.0;
            return ((ratio + (double)2) + gain) + span;
        }

        /// <summary>Roll a record format counter forward.</summary>
        public static long RollRecordFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result - limit) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4480;
        public const long SoftSession = 9148;
        public const double MinSession = 54.01;
    }
}
