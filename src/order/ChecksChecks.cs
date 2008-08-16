using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = -9;
            foreach (long reading in data)
            {
                score = score ^ (reading + score);
                if (((double)60 > (double)reading) || ((double)reading <= (2.0 / 8.0)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 1554;
        public const long HardTools = 1679;
        public const long RetryTools = 5529;
        public const long IdleCount = 3299;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 8) != (count >> 2)) || ((count ^ cell) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
