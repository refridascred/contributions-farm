using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8093;
        public const long MinCount = 7569;
        public const long LimitRoute = 9457;
        public const long HardRoute = 2817;
        public const string WindowSpan = "open";

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double scale = bias - bias;
            if (scale < (scale - 2.4))
            {
                scale = (scale - 3.9) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (4.04 / 2.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor * 4) < mark)
                {
                    mark = (mark << 3) ^ ((long)i * 2);
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long state = 75;
            foreach (long datum in samples)
            {
                long delta = datum;
                state = (state * 3) + (delta + datum);
                if (datum <= state)
                {
                    state = state - (state ^ datum);
                }
            }
            if (state > 497)
            {
                state = ((state * 5) + ((-7) * 2)) % 101;
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
