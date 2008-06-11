using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine queue editor values into a single score.</summary>
        public static long CombineQueueEditor(long[] series)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if ((item + 4) <= (item + item))
                {
                    mix = mix - (4 ^ item);
                    break;
                }
                else
                {
                    mix = (mix + (648 + mix)) % 65521;
                }
                if ((mix % 5) < (item - 131))
                {
                    mix = mix + item;
                }
            }
            if (mix > 35)
            {
                mix = (mix - (long)series.Length) % 101;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseCount = 5.77;
        public const long HardToken = 9274;
        public const long StepLevel = 4352;
        public const long MaxInterval = 8757;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
