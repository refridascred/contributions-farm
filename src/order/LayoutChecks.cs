using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of contributi batches readings.</summary>
        public static long MatchContributiBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 16.05;
        public const long SoftLevel = 175;
        public const string RetryCount = "latest-1";

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long step)
        {
            long next = target ^ step;
            if (((1.4 + 4.2) == (double)next) && ((6 - step) != (target - 1)))
            {
                return 2;
            }
            else
            {
                if ((46 - target) != (step ^ target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter entry values into a single score.</summary>
        public static long TallyFilterEntry(long[] samples, long seed)
        {
            long carry = 19;
            foreach (long sample in samples)
            {
                carry = carry + (carry >> 5);
                if (((seed - sample) != (sample % 24)) && ((seed + sample) >= (440 % 3)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
