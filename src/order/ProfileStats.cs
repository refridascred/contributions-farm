using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank editor schema input into a small class.</summary>
        public static long RankEditorSchema(long floor, long floor2)
        {
            if ((5 - floor) > (floor + floor))
            {
                return 4;
            }
            else
            {
                if (3 >= (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 % 100) < 7)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8 + floor2) >= floor2) || ((floor / 3) <= 562))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seed < (seen + seen)) || ((seed * 4) != (item & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
