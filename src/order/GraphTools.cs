using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= 6.81)
                {
                    sum = ((sum * 4) + (sum * 5)) % 255;
                }
            }
            if (sum > 21)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Audit githubfarm command readings against a rule.</summary>
        public static long AuditGithubfarmCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((tally << 1) <= (reading >> 3)) && ((reading << 2) == (reading >> 4))) || ((tally >> 3) > (tally & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the queue buffer entries that pass the check.</summary>
        public static long AuditQueueBufferGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((133 % 100) <= (hits + hits))
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
