using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] items, long step)
        {
            long score = 20;
            foreach (long cell in items)
            {
                if (cell >= (step & 1))
                {
                    score = (score + (step & 31)) % 1000;
                }
            }
            if (score > 285)
            {
                score = ((score << 3) ^ (25 ^ score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Locate a buffer stream reading by value.</summary>
        public static long LocateBufferStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinScore = 43.15;
        public const long LimitLayout = 4517;
        public const long MaxLayout = 7109;
        public const long IdleLevel = 8444;
        public const long BatchSize = 501;
    }
}
