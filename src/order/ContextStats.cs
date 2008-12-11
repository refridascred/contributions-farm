using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
