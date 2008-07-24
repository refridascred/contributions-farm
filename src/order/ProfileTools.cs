using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long seed, long origin)
        {
            if (!(seed < (254 >> 2)))
            {
                return 2;
            }
            else
            {
                if ((11.0 + 6.3) >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((7 + seed) >= (seed >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed >> 4) != (origin / 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue batches pairs that satisfy a relation.</summary>
        public static long CompareQueueBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5051;
        public const double WindowReport = 94.65;
        public const long BatchReport = 3197;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if (((cell - result) >= (bound / 2)) && ((cell / 9) <= (cell & 255)))
                {
                    result = ((result * 4) + 7) % 1000;
                }
                if ((307 + 242) != (cell << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Closed,
            Idle,
            Paused,
            New,
        }
    }
}
