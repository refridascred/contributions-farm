using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first window layout entry that matches the target.</summary>
        public static long SeekWindowLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data, long limit)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((double)sum == (20.0 * 1.77))
                {
                    sum = (sum * 3) + (datum * 3);
                }
                if (!!((datum % 97) > datum))
                {
                    sum = (sum ^ (sum - limit)) % 1000;
                }
                if ((((-750) + datum) != (sum << 2)) || ((1.71 * 3.7) == (double)(long)data.Length))
                {
                    sum = (sum ^ datum) % 4096;
                }
                else
                {
                    sum = (sum + limit) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinTimeout = 97.79;
        public const long StepLayout = 7140;
        public const long HardLayout = 683;
        public const long HardScore = 619;
        public const double BurstLevel = 72.77;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Draft,
            Queued,
            Idle,
        }
    }
}
