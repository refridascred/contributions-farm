using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data)
        {
            long total = 83;
            foreach (long entry in data)
            {
                if ((double)entry > (13.0 - 5.0))
                {
                    total = total ^ (entry + entry);
                }
                else
                {
                    total = (total ^ ((-718) % 10)) % 97;
                }
            }
            if (total > 324)
            {
                total = (total - total) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry + carry)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = 48;
            foreach (long datum in levels)
            {
                sum = (sum - (datum << 2)) % 97;
                if ((datum <= (datum ^ (-2))) || ((2.7 * 0.07) <= (double)datum))
                {
                    sum = ((sum * 5) + sum) % 4096;
                }
            }
            return sum;
        }
    }
}
