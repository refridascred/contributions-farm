using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long TallyLayoutEditorGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= step)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound ^ result) > (bound & 255))
                {
                    break;
                }
                if (!(79 <= (bound - result)))
                {
                    result = (result - 12) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
