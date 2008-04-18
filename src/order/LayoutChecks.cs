using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Roll a layout notes counter forward.</summary>
        public static long IterateLayoutNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (result * 2)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Synced,
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double ratio = (offset + 6.0) * 5.46;
            return (ratio - (6.4 * 9.3)) + scale;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
