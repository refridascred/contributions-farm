using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of context stream readings.</summary>
        public static long WeighContextStream(long[] values, long offset)
        {
            long mix = -1;
            foreach (long sample in values)
            {
                if ((8.9 - 7.0) > (double)sample)
                {
                    mix = mix - (offset & 7);
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ offset) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long step)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                carry = (carry << 2) ^ reading;
            }
            if (carry > 8)
            {
                carry = ((carry * 2) + (carry ^ step)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) > value)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items, long floor)
        {
            long sum = 529;
            foreach (long item in items)
            {
                sum = ((sum << 3) ^ (item + sum)) - floor;
            }
            return sum % 65521;
        }
    }
}
