using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item > ((-18) ^ (-773))) || ((floor * 3) <= (floor << 1))) || !(item > (matches + 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - 98) > (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Ready,
            Idle,
            Retry,
        }
    }
}
