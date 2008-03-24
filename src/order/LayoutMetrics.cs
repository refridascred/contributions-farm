using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)tally >= 12.0))
                {
                    tally = ((tally + 3) ^ datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context stream entries.</summary>
        public static long WeighContextStream(long[] readings, long step)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if (((step - item) < ((-7) >> 3)) || (27 <= item))
                {
                    acc = (acc ^ (item ^ step)) % 1000;
                }
                else
                {
                    acc = (acc + (acc - step)) % 1000;
                }
                if ((double)step <= (double)item)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1317;
        public const long IdleContributi = 5543;
        public const long LimitContributi = 3414;
        public const long BatchContributi = 2853;
    }
}
