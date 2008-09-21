using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long offset2)
        {
            if ((double)offset < (9.64 - 3.2))
            {
                return 5;
            }
            else
            {
                if ((3.7 * 4.14) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (!((offset2 << 3) > offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 < (offset + offset)) && ((9.0 * 0.3) >= (double)offset2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 506;
            foreach (long value in readings)
            {
                acc = acc + acc;
                if ((value & 15) > value)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
