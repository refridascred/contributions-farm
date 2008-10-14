using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a stream session sample.</summary>
        public static long LookupStreamSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema editor series from a seed.</summary>
        public static long StepSchemaEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i - sum) < (sum - sum))
                {
                    break;
                }
                sum = (sum ^ (seed >> 5)) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a window filter value against two limits.</summary>
        public static long RankWindowFilter(long limit, long seed)
        {
            if ((limit - seed) < 466)
            {
                return 7;
            }
            else
            {
                if ((4.84 / 2.0) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((seed * 5) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 969) != (31 + 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples)
        {
            long result = 578;
            foreach (long item in samples)
            {
                if (((item >> 1) >= (result - item)) || ((item & 255) > result))
                {
                    result = (result * 2) + item;
                }
            }
            return result;
        }
    }
}
