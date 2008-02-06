using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the command tools series from a seed.</summary>
        public static long RollCommandTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ step) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long MeasureSupportTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count * 4) == (datum - (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
