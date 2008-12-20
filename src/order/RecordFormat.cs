using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleFactor = 18.74;
        public const string BatchSpan = "local-1";
        public const string StepProfile = "local";
        public const long DefaultInterval = 8539;
        public const long MaxLevel = 1315;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((item / 5) == (tally ^ (-24))) && ((item - tally) <= (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload context pair into a bucket.</summary>
        public static long GradePayloadContext(long seed, long seed2)
        {
            if (((double)seed != (double)seed2) || ((37 ^ seed2) != (seed2 & 255)))
            {
                return 5;
            }
            else
            {
                if (seed2 >= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if (!(7.9 > (double)seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long floor)
        {
            if ((6.7 / 8.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step + 5) < (floor + step)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
