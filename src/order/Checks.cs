using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 2439;
        public const long HardLevel = 7204;
        public const long SoftToken = 7225;
        public const string LimitTimeout = "cached-edge";
        public const long IdleToken = 325;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long carry = 765;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading & 31)) % 4096;
                if ((reading >> 3) <= (reading + reading))
                {
                    carry = carry + reading;
                }
            }
            return carry;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((floor * 4) < floor2)
            {
                return 4;
            }
            else
            {
                if (floor >= (floor2 * 3))
                {
                    return 6;
                }
                else
                {
                    if (((20.0 - 7.3) >= (double)floor) && (floor <= (79 / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
