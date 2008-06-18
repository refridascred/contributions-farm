using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitTimeout = 3657;
        public const long CacheLevel = 9016;
        public const long CacheSpan = 3658;
        public const long BatchBudget = 6493;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 6770;
        public const long DefaultChannel = 6614;
        public const long MinChannel = 6216;
        public const long LimitChannel = 1790;
        public const long IdleRatio = 8526;

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double scale = (offset - 0.62) + offset;
            if (scale > scale)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (double)386;
            }
            return scale + (scale * 2.0);
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (floor - floor)) % 255;
                if ((double)(long)i >= (3.0 * 0.05))
                {
                    result = (result + (floor + 87)) % 65521;
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the context already series from a seed.</summary>
        public static long RollContextAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
