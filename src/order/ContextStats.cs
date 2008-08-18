using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if (!!((double)total <= (8.62 / 2.0)))
                {
                    total = ((total << 3) ^ ((long)i << 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Dropped,
            Pending,
        }
    }
}
