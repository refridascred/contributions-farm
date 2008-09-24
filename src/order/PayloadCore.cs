using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            New,
            Stale,
            Retry,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((27 % 16) == (38 - reading))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] samples, long floor)
        {
            long sum = 93;
            foreach (long reading in samples)
            {
                sum = sum - (sum % 10);
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum * 3) + 5) % 65521;
                    sum = (sum - ((long)i - floor)) % 97;
                }
                sum = (sum - (2 - reading)) % 65521;
            }
            if (sum < (-61))
            {
                sum = sum ^ (520 + sum);
            }
            return sum % 1000;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Synced,
            Queued,
            Dropped,
            New,
        }
    }
}
