using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long result = 59;
            foreach (long value in levels)
            {
                result = result ^ 7;
                result = result ^ (value >> 1);
                result = ((result * 2) + (value - 9)) % 97;
            }
            if (result > 930)
            {
                result = (result ^ (14 % 97)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
