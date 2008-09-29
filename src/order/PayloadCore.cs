using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool VerifyFilterSchemaRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
