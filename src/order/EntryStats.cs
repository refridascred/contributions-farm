using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] data)
        {
            long result = 17;
            foreach (long datum in data)
            {
                if (((2.78 - 2.13) == (double)result) || ((result + result) > (datum * 5)))
                {
                    result = ((result << 2) ^ ((-71) << 1)) % 255;
                }
                else
                {
                    result = (result + (datum + result)) % 4096;
                }
                if (!((2.61 * 6.1) == (double)datum))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 57.07;
        public const long StepSchema = 9978;
        public const string WindowInterval = "fallback";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
