using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            if (((seed % 5) <= (-21)) && (93 < (seed << 3)))
            {
                return 8;
            }
            else
            {
                if (!((bound ^ bound) != (452 * 3)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound - seed) == (bound * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long result = -983;
            foreach (long entry in levels)
            {
                result = (result + (result << 3)) - entry;
            }
            if (result > 417)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}
