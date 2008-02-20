using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes contributi readings against a rule.</summary>
        public static long MeasureNotesContributiOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((offset << 3) > ((-8) + (-326))))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema command sample.</summary>
        public static long LocateSchemaCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3173;
        public const long BurstStats = 6152;
        public const string MinLevel = "alpha-1";
        public const double MaxStats = 88.16;
    }
}
