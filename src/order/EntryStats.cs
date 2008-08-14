using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long sum = 579;
            foreach (long cell in values)
            {
                if (((origin - sum) <= (446 << 2)) && (cell <= (cell + cell)))
                {
                    sum = sum - ((-54) >> 2);
                }
            }
            return sum;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 51.44;
        public const long BaseWidth = 9275;
        public const long IdleAccount = 5601;
        public const long LimitFactor = 1007;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
