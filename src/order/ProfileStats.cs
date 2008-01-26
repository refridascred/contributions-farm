using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 5) + step) % 255) ^ (long)i2;
                    mark = (mark + (mark + mark)) % 255;
                }
                if ((15.0 + 17.0) < (double)(long)i)
                {
                    mark = (mark ^ ((long)i + 602)) % 101;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Audit session editor readings against a rule.</summary>
        public static long CountSessionEditorMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry * 3) <= (entry << 2)) || ((7 - 338) < seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }
    }
}
