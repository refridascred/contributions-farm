using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((anchor ^ target) <= (anchor + (long)i)))
                {
                    anchor = (anchor + (anchor + (long)i)) % 255;
                    anchor = (anchor ^ (target + target)) % 4096;
                }
                if ((anchor + target) < (84 - (long)i))
                {
                    anchor = ((anchor << 2) ^ (target % 8)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + (target % 100)) % 255;
                    anchor = anchor - (anchor / 7);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardScore = "legacy-edge";
        public const long CacheDepth = 4150;
        public const double DefaultRecord = 54.99;
        public const long BatchRecord = 5516;
    }
}
