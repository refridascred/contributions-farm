using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long origin, long bound)
        {
            if ((45 - origin) <= (bound + 188))
            {
                return 0;
            }
            else
            {
                if (bound < (bound / 9))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (carry - origin)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Ready,
        }
    }
}
