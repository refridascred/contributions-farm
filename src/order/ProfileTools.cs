using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double scale2 = (scale / 5.0) / 5.0;
            if (scale2 > scale2)
            {
                scale2 = scale2 + (double)89;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            return scale2 + scale2;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (limit & 1)) % 65521;
                state = ((state << 2) ^ (long)i) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 6656;
        public const double WindowStream = 98.26;
        public const long SoftStream = 9374;
    }
}
