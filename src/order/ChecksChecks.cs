using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score ^ (score + entry)) % 65521;
                if (!((507 - entry) < score))
                {
                    score = ((score * 5) + 8) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long step)
        {
            if ((double)origin <= (9.2 * 11.0))
            {
                return 1;
            }
            else
            {
                if (9.6 > (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((step + step) >= step) && ((double)origin <= (7.1 - 3.9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
