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

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double rate = (double)(1 * 4);
            if (rate >= (rate * 3.0))
            {
                rate = (rate + floor) - gain;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - (double)842;
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
