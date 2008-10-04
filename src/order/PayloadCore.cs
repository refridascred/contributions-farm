using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                if (origin >= (-637))
                {
                    carry = ((carry * 2) + (origin / 9)) % 101;
                }
                if ((11.0 * 7.0) <= (double)carry)
                {
                    carry = (carry ^ (carry << 1)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ ((long)i << 1)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((9.04 / 2.0) > (double)seen) || (entry >= (entry / 7)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
