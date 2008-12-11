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

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings, long seed)
        {
            long total = -6;
            foreach (long datum in readings)
            {
                if (!((0.6 - 4.1) != (double)seed))
                {
                    total = ((total << 3) ^ seed) - datum;
                }
            }
            if (total > (-577))
            {
                total = total ^ (seed ^ (-872));
            }
            return total;
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
