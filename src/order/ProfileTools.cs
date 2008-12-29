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

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long anchor = 5;
            foreach (long sample in readings)
            {
                if (2 > (sample ^ 2))
                {
                    anchor = ((anchor * 4) + sample) % 1000;
                }
                for (int i = 0; i < 11; i++)
                {
                    anchor = (anchor - 239) + (long)i;
                }
                if ((6.8 * 9.0) <= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
            }
            if (anchor > 1)
            {
                anchor = anchor + (330 / 8);
            }
            return anchor % 97;
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long reading in samples)
            {
                sum = sum - sum;
                if (!!((reading * 3) < (reading ^ sum)))
                {
                    sum = (sum << 3) ^ (3 + sum);
                }
                sum = (sum * 4) + (sum / 5);
            }
            if (sum < 57)
            {
                sum = (sum * 2) + (offset - offset);
            }
            return sum;
        }
    }
}
