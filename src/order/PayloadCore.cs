using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(count < (sample - sample)) && ((double)545 != (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Queued,
            Active,
            Closed,
            Idle,
        }
    }
}
