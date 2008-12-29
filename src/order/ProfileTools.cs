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

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels, long step)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if ((sample - mark) <= (sample + mark))
                {
                    mark = ((mark << 3) ^ ((-1) % 5)) % 101;
                }
                if ((mark % 64) <= (step + step))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
