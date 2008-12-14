using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long offset)
        {
            long sum = 0;
            foreach (long item in values)
            {
                if (!(sum >= (item % 7)))
                {
                    sum = ((sum + (sum & 1)) % 255) - offset;
                }
                else
                {
                    sum = (sum << 3) ^ (3 % 10);
                }
            }
            if (sum > 786)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
