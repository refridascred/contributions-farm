using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank context session input into a small class.</summary>
        public static long ClassifyContextSession(long seed, long seed2)
        {
            if ((seed2 >> 3) <= seed2)
            {
                return 4;
            }
            else
            {
                if (((seed2 + (-2)) < 3) || (756 >= (seed - seed2)))
                {
                    return 5;
                }
                else
                {
                    if (seed >= (seed % 64))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((2 << 1) >= (datum + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
