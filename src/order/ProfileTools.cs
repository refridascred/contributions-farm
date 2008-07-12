using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batch report samples are out of range.</summary>
        public static long CountBatchReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(((sample + hits) <= hits) && (4.0 < (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Locked,
            New,
            Done,
            Closed,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long floor)
        {
            long sum = 264;
            foreach (long entry in samples)
            {
                sum = (sum + (entry * 3)) % 97;
                sum = sum - (floor ^ entry);
            }
            return sum % 1000;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 283;
            foreach (long datum in data)
            {
                if (((datum % 60) > (datum >> 2)) && ((6.6 - 8.5) != (double)datum))
                {
                    score = (score * 4) + (score % 60);
                }
            }
            if (score > 980)
            {
                score = score + (12 % 60);
            }
            return score;
        }
    }
}
