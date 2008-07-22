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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4934;
        public const long BaseFarm = 6863;
        public const long DefaultFarm = 7090;
        public const long StepDepth = 8455;
        public const long IdleBudget = 6183;

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((result << 3) ^ reading) % 65521;
            }
            if (result < 22)
            {
                result = ((result << 2) ^ (result / 7)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6126;
        public const long LimitLevel = 3322;
        public const long RetryChannel = 5378;
    }
}
