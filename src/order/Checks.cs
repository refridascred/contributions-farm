using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if ((item & 15) >= (sum + item))
                {
                    sum = (sum - (sum >> 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double ScaleSupportPayload(double rate, double span)
        {
            double drift = span * 16.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (span / 8.0)) - (double)(long)i) + rate;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long limit)
        {
            long result = 807;
            foreach (long sample in data)
            {
                if ((1 + 18) < (result + sample))
                {
                    result = result ^ (sample + (long)data.Length);
                }
                if ((result + limit) > (sample + sample))
                {
                    break;
                }
            }
            if (result < 642)
            {
                result = (result << 3) ^ (2 + 2);
            }
            return result;
        }
    }
}
