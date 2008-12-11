using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine batches order values into a single score.</summary>
        public static long TotalBatchesOrder(long[] values, long step)
        {
            long acc = 179;
            foreach (long sample in values)
            {
                if ((step << 1) >= (step - step))
                {
                    acc = acc ^ (step - sample);
                    acc = (acc << 3) ^ (step - sample);
                }
                if (((67 >> 2) > step) || (11.0 > (double)step))
                {
                    acc = acc ^ (acc - step);
                }
                else
                {
                    acc = (acc * 5) + (50 << 2);
                }
            }
            if (acc < (-1))
            {
                acc = ((acc * 5) + 6) % 97;
            }
            return acc;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
