using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long target)
        {
            if (target < (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (2.13 + 9.1))
                {
                    return 0;
                }
                else
                {
                    if ((24 ^ target) <= (target ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepRatio = 1057;
        public const long SoftCache = 9906;
        public const long SoftSize = 2703;
        public const long MaxCache = 6788;
        public const long BatchCache = 7377;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
