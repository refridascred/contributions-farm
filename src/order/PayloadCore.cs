using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long carry = 15;
            foreach (long datum in readings)
            {
                if ((169 % 8) > (213 - datum))
                {
                    carry = (carry + (265 * 2)) % 65521;
                }
                else
                {
                    carry = carry + 928;
                }
                if ((datum + 53) != (datum + carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
