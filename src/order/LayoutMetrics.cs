using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor + 436) <= (seed & 15))
                {
                    anchor = (anchor ^ ((long)i << 2)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool ValidateEditorAccountRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
