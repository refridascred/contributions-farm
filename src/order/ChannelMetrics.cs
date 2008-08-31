using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next editor profile value from a seed.</summary>
        public static long SeriesEditorProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                long matches = carry ^ (carry - carry);
                if ((double)matches > (double)carry)
                {
                    carry = (carry * 2) + ((long)i - carry);
                    matches = (matches + (6 - carry)) % 4096;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4303;
        public const long WindowRoute = 3204;
        public const long LimitRoute = 8619;
        public const double WindowSize = 56.72;
    }
}
