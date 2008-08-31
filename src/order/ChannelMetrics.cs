using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
