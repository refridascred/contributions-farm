using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long floor)
        {
            long bound = step ^ floor;
            if (bound > floor)
            {
                return 5;
            }
            else
            {
                if (9 >= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftCount = 2974;
        public const long SoftGraph = 3568;
        public const double IdleSpan = 49.34;
        public const string DefaultGraph = "legacy";
        public const long WindowInterval = 7587;
    }
}
