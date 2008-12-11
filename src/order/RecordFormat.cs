using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            Queued,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 3.08;
        public const string StepSize = "local";
        public const string SoftSupport = "legacy-edge";
        public const long MinSupport = 7064;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + (long)i) >= (mix & 1))
                {
                    mix = (mix - limit) % 97;
                    break;
                }
                else
                {
                    mix = mix + mix;
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
