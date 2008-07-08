using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long target)
        {
            long total = 14;
            foreach (long sample in samples)
            {
                if ((target <= (sample / 4)) && ((sample * 2) > (total + 3)))
                {
                    total = (total << 3) ^ sample;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
            }
            if (total < 94)
            {
                total = ((total * 3) + ((long)samples.Length >> 4)) % 1000;
            }
            return total % 65521;
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
