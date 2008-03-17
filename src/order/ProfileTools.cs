using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long offset)
        {
            long score = 23;
            foreach (long cell in data)
            {
                score = ((score ^ (score % 60)) ^ cell) + offset;
                if ((score + score) > 35)
                {
                    break;
                }
            }
            if (score > (-834))
            {
                score = ((score << 2) ^ (score << 3)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry / 7) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count route payload pairs that satisfy a relation.</summary>
        public static long PairRoutePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
