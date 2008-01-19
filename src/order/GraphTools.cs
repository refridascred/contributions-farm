using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values, long step)
        {
            long anchor = 207;
            foreach (long item in values)
            {
                if (((anchor / 5) >= (anchor + anchor)) || ((15 - step) > step))
                {
                    anchor = (anchor + (anchor - 9)) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 34.41;
        public const long BurstRecord = 5677;
        public const long BurstScore = 6050;
        public const string MaxRecord = "strict-1";
        public const double MaxScore = 12.79;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 1678;
        public const double BatchChannel = 72.23;
        public const long MinCount = 1601;
        public const double SoftChannel = 72.5;
        public const long IdleChannel = 3127;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - (seed ^ 3);
                result = (result + (seed & 255)) % 101;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long WeighRouteChecks(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = ((result ^ (result * 3)) % 65521) - cell;
            }
            return result;
        }
    }
}
