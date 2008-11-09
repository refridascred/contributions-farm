using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of context payload readings.</summary>
        public static long FoldContextPayload(long[] samples, long floor)
        {
            long anchor = 95;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor * 4) + (floor / 5)) % 101;
                    anchor = anchor - (anchor + (long)i);
                }
                if (((double)floor == (6.25 / 2.0)) || (cell >= anchor))
                {
                    anchor = anchor ^ (anchor * 2);
                }
                if (cell >= (cell + 66))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long result = 67;
            foreach (long value in values)
            {
                if (7 > (value ^ result))
                {
                    result = ((result << 2) ^ (value + (long)values.Length)) % 4096;
                }
                else
                {
                    result = result + (value << 3);
                }
            }
            if (result > 78)
            {
                result = (result + (result - result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
