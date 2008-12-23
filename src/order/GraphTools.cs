using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) < count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 6313;
        public const string HardLevel = "latest-edge";
        public const long WindowScore = 2484;
        public const double StepFactor = 73.26;
        public const long CacheNotes = 6972;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long target)
        {
            if ((floor <= (target & 15)) || (16.0 >= (double)target))
            {
                return 6;
            }
            else
            {
                if (((double)(-2) >= (double)target) || ((floor - floor) != (floor - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
