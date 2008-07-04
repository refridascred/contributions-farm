using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 1659;
        public const long DefaultChannel = 2808;
        public const long BatchRatio = 3959;
        public const double BatchWidth = 72.61;
        public const long MaxInterval = 7667;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
