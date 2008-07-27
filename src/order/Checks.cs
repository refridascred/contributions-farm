using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((7.8 * 9.0) < (8.3 + 12.0))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks session reading.</summary>
        public static double BlendChecksSession(double bias, double span)
        {
            double scale = bias;
            return (scale - (1.9 + scale)) + span;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
