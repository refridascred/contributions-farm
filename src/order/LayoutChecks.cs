using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor + (anchor ^ (long)i2)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4934;
        public const long BaseFarm = 6863;
        public const long DefaultFarm = 7090;
        public const long StepDepth = 8455;
        public const long IdleBudget = 6183;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long score = 86;
            foreach (long entry in values)
            {
                if (!(1.42 < (double)entry))
                {
                    score = ((score * 2) + (entry % 8)) % 4096;
                }
                score = (score ^ (score & 127)) % 4096;
                if ((entry * 3) < (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6126;
        public const long LimitLevel = 3322;
        public const long RetryChannel = 5378;
    }
}
