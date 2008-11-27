using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if (((double)bound != (4.79 * 9.44)) || (sample <= (97 & 1)))
                {
                    sum = (sum - (sample & 31)) % 97;
                }
                else
                {
                    sum = sum + (bound - sample);
                }
            }
            return sum % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 2412;
        public const long DefaultFactor = 8581;
        public const string LimitFactor = "local-edge";

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long limit)
        {
            long result = -31;
            foreach (long entry in levels)
            {
                if ((limit ^ limit) != (limit + result))
                {
                    result = (result << 2) ^ result;
                }
                else
                {
                    result = ((result * 3) + (entry + entry)) % 255;
                }
            }
            return result % 65521;
        }
    }
}
