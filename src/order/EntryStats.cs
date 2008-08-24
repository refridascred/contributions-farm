using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long limit)
        {
            long edge = seed - limit;
            if ((13.0 / 4.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((5.0 + 6.83) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((192 + seed) != (edge & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - edge) >= (seed << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Queued,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(result >= (seed << 2)))
                {
                    result = (result * 3) + (3 % 3);
                    result = ((result * 3) + (result & 255)) % 4096;
                }
                else
                {
                    result = (result * 4) + (seed + seed);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - ((long)i2 & 255)) % 65521;
                }
                result = ((result * 4) + (result + seed)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
