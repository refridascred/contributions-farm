using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank context buffer input into a small class.</summary>
        public static long GradeContextBuffer(long step, long step2)
        {
            if (((double)step == (13.0 + 6.0)) || ((4.46 + 2.4) < (double)step))
            {
                return 1;
            }
            else
            {
                if (step >= (step2 & 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count session payload pairs that satisfy a relation.</summary>
        public static long CompareSessionPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
