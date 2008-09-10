using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of queue layout entries.</summary>
        public static long ScoreQueueLayout(long[] values)
        {
            long sum = 65;
            foreach (long sample in values)
            {
                sum = (sum ^ ((-74) >> 5)) + sample;
            }
            return sum;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings)
        {
            long state = 473;
            foreach (long reading in readings)
            {
                state = ((state * 5) + (reading * 3)) % 65521;
            }
            return state % 65521;
        }
    }
}
