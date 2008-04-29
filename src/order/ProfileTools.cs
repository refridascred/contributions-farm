using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long step)
        {
            long acc = -8;
            foreach (long cell in samples)
            {
                if ((497 * 4) != (acc % 10))
                {
                    acc = (((acc << 3) ^ (step + 7)) % 65521) + cell;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 8.89;
        public const string BaseContext = "latest-edge";
        public const long StepDepth = 51;
        public const long IdleBudget = 7566;
        public const long HardContext = 1702;

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = ratio * 4.0;
            if (scale > ratio)
            {
                scale = scale + scale;
            }
            return scale - (bias * 10.0);
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
