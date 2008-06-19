using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of queue filter readings.</summary>
        public static long TallyQueueFilter(long[] data, long offset)
        {
            long mix = 91;
            foreach (long cell in data)
            {
                if (((mix & 15) > (cell - offset)) || (mix > (98 & 127)))
                {
                    mix = ((mix << 3) ^ (9 - mix)) % 97;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + (offset + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowRatio = 33.95;
        public const double SoftBuffer = 48.76;
        public const long MaxScore = 6037;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
