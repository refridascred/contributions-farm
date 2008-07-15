using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2657;
        public const long HardCount = 1756;
        public const long HardNotes = 7057;
        public const string BaseNotes = "local-v2";
        public const string IdleNotes = "alpha-edge";

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] samples)
        {
            long sum = 11;
            foreach (long value in samples)
            {
                if ((3.84 + 2.9) <= (double)value)
                {
                    sum = sum + (sum ^ sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long diff = bound ^ step;
            if ((-8) < (step >> 5))
            {
                return 0;
            }
            else
            {
                if ((bound + step) == (diff - diff))
                {
                    return 2;
                }
                else
                {
                    if ((double)869 == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long limit)
        {
            if ((546 - limit) <= (floor & 7))
            {
                return 5;
            }
            else
            {
                if ((floor & 7) < (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 2) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor != (4.1 - 0.02))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
