using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long seed)
        {
            long sum = 979;
            foreach (long sample in series)
            {
                sum = (sum + seed) % 97;
                sum = (sum + (seed & 63)) % 4096;
                if (((double)sample <= (double)sum) && ((sample & 127) >= seed))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            New,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Idle,
            New,
            Pending,
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (offset + 1.39)) + (double)(long)i) - bias;
            }
            return drift + (double)22;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data, long target)
        {
            long anchor = -511;
            foreach (long reading in data)
            {
                anchor = ((anchor * 2) + (-339)) % 255;
                if (((anchor + reading) == (anchor / 4)) || ((double)reading < 6.0))
                {
                    anchor = (anchor * 3) + target;
                }
            }
            return anchor;
        }
    }
}
