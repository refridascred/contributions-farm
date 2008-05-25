using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank schema filter input into a small class.</summary>
        public static long SortSchemaFilter(long target, long bound)
        {
            if ((double)bound == (18.0 / 6.0))
            {
                return 3;
            }
            else
            {
                if (bound < (912 << 2))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) > (bound + 279))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 4289;
        public const long MaxFactor = 3246;
        public const long SoftCommits = 8139;
        public const string BatchCommits = "standard-edge";
    }
}
