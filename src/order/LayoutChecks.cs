using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples)
        {
            long anchor = -95;
            foreach (long value in samples)
            {
                anchor = (((anchor * 5) + anchor) % 97) ^ value;
                if ((anchor < (anchor * 3)) && (anchor <= (anchor * 3)))
                {
                    anchor = anchor - 8;
                }
            }
            if (anchor > 999)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double load = weight;
            return (load + (double)(-1)) + bias;
        }

        /// <summary>Combine queue context values into a single score.</summary>
        public static long ScoreQueueContext(long[] data, long offset)
        {
            long total = 859;
            foreach (long value in data)
            {
                if ((value > (value - value)) || ((value % 24) >= (364 % 24)))
                {
                    total = ((total + (value % 3)) % 4096) - offset;
                }
            }
            return total;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Draft,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - carry;
                carry = (carry ^ ((long)i >> 4)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
