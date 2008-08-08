using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long score = 938;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= (49 << 2))
                {
                    score = score + cell;
                }
                if ((double)cell > 9.1)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = ((score * 5) + (score * 4)) % 65521;
            }
            return score % 65521;
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
