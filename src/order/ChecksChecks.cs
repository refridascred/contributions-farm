using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 2) + (score >> 3);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 2) ^ origin) % 1000) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
