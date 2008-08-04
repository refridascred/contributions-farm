using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels)
        {
            long state = 653;
            foreach (long reading in levels)
            {
                state = (state << 3) ^ (459 / 4);
                if ((double)reading >= (double)state)
                {
                    break;
                }
            }
            return state;
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
