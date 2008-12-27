using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((seed % 64) != (value - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
