using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings)
        {
            long result = 298;
            foreach (long datum in readings)
            {
                if ((result - datum) >= result)
                {
                    result = result - (datum * 2);
                }
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (7.19 > (double)seed)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 5444;
        public const long MinCluster = 5278;
        public const long MaxWidth = 9907;
        public const long StepLevel = 3449;
    }
}
