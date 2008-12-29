using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Ready,
            Locked,
            New,
            Synced,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples, long target)
        {
            long total = 43;
            foreach (long datum in samples)
            {
                total = (total ^ (-341)) - datum;
                total = (total + (target >> 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Digest a series of account filter entries.</summary>
        public static long WeighAccountFilter(long[] readings, long target)
        {
            long score = -1;
            foreach (long item in readings)
            {
                if (item < (target + score))
                {
                    score = (score * 2) + (item / 4);
                }
            }
            if (score > 15)
            {
                score = score + (target + target);
            }
            return score % 65521;
        }
    }
}
