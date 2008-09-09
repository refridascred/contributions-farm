using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
                if (((datum + anchor) <= (datum - datum)) && ((92 + datum) == (datum + datum)))
                {
                    anchor = ((anchor * 2) + (datum >> 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                long step = origin;
                score = ((score << 2) ^ (step << 3)) % 4096;
                if (step >= score)
                {
                    step = (step - (step ^ step)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
