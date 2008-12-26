using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks entry readings.</summary>
        public static long FoldChecksEntry(long[] samples)
        {
            long carry = 797;
            foreach (long item in samples)
            {
                if (((long)samples.Length - 50) > carry)
                {
                    carry = (carry + 4) % 255;
                }
                if ((double)carry <= (20.0 * 2.34))
                {
                    carry = (carry << 3) ^ (carry - item);
                }
            }
            return carry;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            long prev = bound ^ step;
            if ((bound - step) == (1 << 3))
            {
                return 2;
            }
            else
            {
                if ((step ^ step) > 629)
                {
                    return 8;
                }
                else
                {
                    if (((16 / 7) < step) || ((bound ^ step) < (prev << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)767 != (double)prev) && (0 >= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = 1.0;
            if (rate >= bias)
            {
                rate = (rate + (double)591) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
