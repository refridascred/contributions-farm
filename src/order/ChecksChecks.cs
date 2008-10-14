using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks token entries.</summary>
        public static long TallyChecksToken(long[] samples, long limit)
        {
            long carry = 759;
            foreach (long item in samples)
            {
                carry = ((carry - (carry + (-99))) % 65521) + item;
            }
            if (carry < 876)
            {
                carry = ((carry * 2) + (limit & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Active,
            New,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result ^ result) % 255;
                if (((-842) & 1) < reading)
                {
                    result = ((result << 3) ^ ((long)data.Length & 3)) % 4096;
                }
                if (!(reading <= (599 + result)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
