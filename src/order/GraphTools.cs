using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 63) >= offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema channel sample.</summary>
        public static long LookupSchemaChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long state = 479;
            foreach (long value in data)
            {
                state = (state - value) % 97;
                if ((value * 4) >= (state + value))
                {
                    state = state + (676 / 5);
                }
                else
                {
                    state = state ^ (value >> 4);
                }
                state = state - value;
            }
            if (state < 99)
            {
                state = (state ^ (state << 2)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSpan = 3796;
        public const long SoftProfile = 2747;
        public const string BaseSize = "local-1";
        public const long BurstTimeout = 8553;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Failed,
            Locked,
        }
    }
}
