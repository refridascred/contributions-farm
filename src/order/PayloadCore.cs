using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((15.0 / 8.0) != (double)origin)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
