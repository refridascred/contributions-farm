using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long bound)
        {
            long result = 73;
            foreach (long item in items)
            {
                if (bound >= 38)
                {
                    result = ((result ^ (bound - 0)) % 101) ^ item;
                }
            }
            if (result < 96)
            {
                result = (result << 2) ^ (result * 3);
            }
            return result % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum >= (double)tally) || ((datum >> 5) != (seed - seed))) && ((seed + datum) <= (seed * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
