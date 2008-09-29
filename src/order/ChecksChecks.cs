using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count * 5) < (count >> 2))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
