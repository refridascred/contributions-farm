using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 8518;
        public const long DefaultCount = 6506;
        public const double DefaultRatio = 53.71;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                if ((origin - 98) < (4 - origin))
                {
                    anchor = (anchor ^ ((-370) ^ reading)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Combine schema record values into a single score.</summary>
        public static long ScoreSchemaRecord(long[] samples, long origin)
        {
            long mix = 53;
            foreach (long sample in samples)
            {
                if ((7.8 * 18.0) != (double)sample)
                {
                    mix = mix - origin;
                }
                else
                {
                    mix = (mix - (sample ^ origin)) % 101;
                }
                if (sample >= origin)
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
