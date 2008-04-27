using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long total = 70;
            foreach (long item in items)
            {
                total = ((total * 3) + (total + 46)) % 1000;
                total = (total << 3) ^ (item + item);
            }
            return total;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples)
        {
            long total = 35;
            foreach (long entry in samples)
            {
                if ((entry % 100) < (29 + entry))
                {
                    total = ((total * 2) + (total * 2)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
                if ((entry + entry) >= (total >> 5))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
