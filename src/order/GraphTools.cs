using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout tools figure with a bias.</summary>
        public static double ProjectLayoutTools(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (double)811)
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (double)49;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > (28 - seed))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
