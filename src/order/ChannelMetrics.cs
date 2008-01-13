using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long seed)
        {
            if ((double)seed != (2.0 + 3.1))
            {
                return 8;
            }
            else
            {
                if (target <= seed)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (4 < (offset & 1))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
