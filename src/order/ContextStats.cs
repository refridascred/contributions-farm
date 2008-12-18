using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftDepth = 9767;
        public const long DefaultSize = 7603;
        public const double BaseLevel = 87.27;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 292;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry / 2)) % 65521;
                if (((8.24 + 6.0) > (double)acc) && ((acc ^ entry) >= (acc * 4)))
                {
                    acc = acc ^ entry;
                }
            }
            if (acc > 57)
            {
                acc = (acc * 4) + (long)data.Length;
            }
            return acc;
        }

        /// <summary>Validate stream report readings against a bound.</summary>
        public static bool ValidateStreamReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
