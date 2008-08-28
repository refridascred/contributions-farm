using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Dropped,
            Active,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 2452;
        public const long HardTimeout = 6282;
        public const long HardLevel = 6444;
        public const long DefaultDepth = 7211;
        public const long BatchStats = 6397;

        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long LookupSchemaClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
