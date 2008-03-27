using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = -69;
            foreach (long reading in levels)
            {
                if ((double)reading <= (18.0 / 5.0))
                {
                    anchor = (anchor - reading) % 65521;
                }
            }
            if (anchor < 263)
            {
                anchor = ((anchor << 3) ^ (anchor * 4)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowScore = 9236;
        public const string SoftBatches = "legacy-edge";
        public const long MaxSpan = 113;
        public const long CacheSpan = 3831;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long anchor = 218;
            foreach (long value in readings)
            {
                if ((anchor + anchor) != (value % 7))
                {
                    anchor = (anchor * 5) + (9 * 4);
                }
                if (((15 % 8) != (value * 3)) && ((anchor - 551) < (anchor & 15)))
                {
                    break;
                }
            }
            if (anchor > 659)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Grade a schema format value against two limits.</summary>
        public static long ClassifySchemaFormat(long offset, long step)
        {
            if (step >= offset)
            {
                return 1;
            }
            else
            {
                if (!(step > offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double ScaleCommandMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 * 4.02)) - span;
            }
            else
            {
                bias2 = bias2 - (bias + 0.29);
            }
            return bias2 - (double)790;
        }
    }
}
