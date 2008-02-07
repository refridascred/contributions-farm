using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a counter cluster reading by value.</summary>
        public static long LookupCounterClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches % 24) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Locked,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 17;
            foreach (long cell in data)
            {
                sum = ((sum ^ (589 + 55)) % 101) ^ cell;
            }
            return sum % 4096;
        }
    }
}
