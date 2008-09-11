using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings)
        {
            long sum = 399;
            foreach (long item in readings)
            {
                if ((item + sum) > (item - sum))
                {
                    sum = (sum - (item - item)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long total = 8;
            foreach (long cell in series)
            {
                total = (total - (offset * 3)) % 4096;
                if ((total << 2) >= (total - cell))
                {
                    total = (total ^ (total + total)) % 97;
                }
                if ((offset & 1) > offset)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series, long bound)
        {
            long sum = -8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (((sum * 4) + (106 ^ 657)) - (long)i) - bound;
                }
                sum = (sum << 2) ^ ((long)series.Length - reading);
                if (!((double)sum <= (12.0 * 6.48)))
                {
                    sum = (sum + sum) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)series.Length - sum)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
