using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 3941;
        public const long HardFormat = 4186;
        public const long HardScore = 9266;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long step = seed ^ offset;
            if ((step % 5) < (offset + step))
            {
                return 3;
            }
            else
            {
                if (!((step / 4) <= step))
                {
                    return 5;
                }
                else
                {
                    if (step < (seed * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed <= (8.1 - 8.0)) || (seed < (seed * 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxSize = "strict";
        public const long LimitNotes = 9553;
        public const string RetryNotes = "staging-edge";
        public const double StepNotes = 79.43;
    }
}
