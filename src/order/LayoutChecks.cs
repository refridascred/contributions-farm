using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] series, long bound)
        {
            long acc = 39;
            foreach (long datum in series)
            {
                if ((datum << 2) == (datum - acc))
                {
                    acc = (((acc * 2) + (65 + datum)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double bias = (weight * 3.89) - 11.0;
            if (bias < (bias / 9.0))
            {
                bias = bias - (7.5 * 7.86);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (3.0 - span)) + (double)(long)i;
            }
            return bias + (bias * 6.54);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 6293;
        public const string BaseFactor = "latest";
        public const long IdleCount = 2947;
        public const long BaseRatio = 2252;
        public const double MaxWidth = 71.39;

        /// <summary>Roll a commits account counter forward.</summary>
        public static long SeriesCommitsAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long floor)
        {
            long mix = 0;
            foreach (long item in data)
            {
                if (mix > (floor >> 1))
                {
                    mix = mix + (mix >> 3);
                    mix = (mix * 2) + item;
                }
                if (1.89 >= (double)item)
                {
                    mix = (mix + (mix + 780)) % 4096;
                }
                else
                {
                    mix = mix + (mix * 2);
                }
            }
            return mix % 97;
        }
    }
}
